#include "google/cloud/vision/v1/image_annotator_client.h"
#include <google/cloud/storage/client.h>
#include <fstream>
#include <iostream>
#include <oleauto.h>
#include <windows.h>
#include <opencv2/opencv.hpp>
#include <chrono>
#include <thread>
#include <filesystem> // C++17 standard header file name
#include <string>
#include <vector>
#include <cstdlib>

using namespace cv;
using namespace std;
using namespace std::filesystem;

//인코딩 해주는 부분
static int num = 0;
static int num2 = 0;
char* pszAnsi;
char* UTF8ToANSI(char const* pszCode) {
	BSTR bstrWide;
	int nLength;

	// Get nLength of the Wide Char buffer
	nLength =
		MultiByteToWideChar(CP_UTF8, 0, pszCode, strlen(pszCode) + 1, NULL, NULL);
	bstrWide = SysAllocStringLen(NULL, nLength);

	// Change UTF-8 to Unicode (UTF-16)
	MultiByteToWideChar(CP_UTF8, 0, pszCode, strlen(pszCode) + 1, bstrWide,
		nLength);

	// Get nLength of the multi byte buffer
	nLength = WideCharToMultiByte(CP_ACP, 0, bstrWide, -1, NULL, 0, NULL, NULL);
	pszAnsi = new char[nLength];

	// Change from unicode to mult byte
	WideCharToMultiByte(CP_ACP, 0, bstrWide, -1, pszAnsi, nLength, NULL, NULL);
	SysFreeString(bstrWide);

	return pszAnsi;
}
std::string UploadFileToGCS(std::string local_file_path,
	std::string bucket_name) {
	namespace gcs = google::cloud::storage;

	// Initialize Google Cloud Storage client
	gcs::Client client;

	// Extract the file name from the local file path
	std::string file_name =
		local_file_path.substr(local_file_path.find_last_of("/\\") + 1);

	// Construct the GCS object name using a random suffix to avoid name
	// collisions
	std::string object_name =
		file_name + "-" + std::to_string(std::time(nullptr));

	// Upload the file to GCS
	client.UploadFile(local_file_path, bucket_name, object_name);

	// Generate the GCS URI for the uploaded file
	std::string gcs_uri = "gs://" + bucket_name + "/" + object_name;

	return gcs_uri;
}
void print_1()      // 단순 메뉴 출력용
{
	Sleep(500);     // 이전의 출력문 대기시간
	system("cls");  // 콘솔창 클리어
	cout << "************** < 신분증 사진 및 글자 검출 프로그램 > **************" << endl
		<< "*     1. 신분증 저장						  *" << endl
		<< "*     2. 신분증 비교						  *" << endl
		<< "*     3. 종료하기						  *" << endl
		<< "*******************************************************************" << endl
		<< "메뉴 번호를 입력하세요: ";
}

//웹캠 연동 부분, 메뉴 1번 = ROI1, 메뉴 2번 = ROI2
int ROI1(int argc, char* argv[])
{
	// 캠 실행
	VideoCapture cap(0);
	if (!cap.isOpened()) { cout << "실패" << endl;  return -1; }
	Mat img_video, img_capt;

	// chrono 함수의 타이머 계산으로 현재 시간 계산
	// 캡쳐 딜레이 조건을 위한 컨투어 판별
	auto start = chrono::high_resolution_clock::now();
	bool contourFound = false;

	for (;;)
	{
		bool ret = cap.read(img_video);
		if (!ret) { cout << "실패 실패 실패" << endl;  break; }
		if (img_video.empty()) { cout << "영상 실패" << endl;  return -1; }

		int height = img_video.rows, width = img_video.cols;
		int center_x = (int)width * 0.5, center_y = (int)height * 0.5;

		Mat img_roi = img_video(Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5)).clone();
		Mat img_gray, img_edge, img_binary;
		Mat img_gray2, img_edge2, img_binary2;

		// 대충 필터링 죄다 쓰기
		// 주민등록증 전체
		cvtColor(img_roi, img_gray, COLOR_BGR2GRAY);
		GaussianBlur(img_gray, img_gray, Size(5, 5), 0);
		adaptiveThreshold(img_gray, img_binary, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray, img_edge, 30, 140, 3);

		// 주민등록증 사진
		cvtColor(img_roi, img_gray2, COLOR_BGR2GRAY);
		GaussianBlur(img_gray2, img_gray2, Size(5, 5), 0);
		adaptiveThreshold(img_gray2, img_binary2, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray2, img_edge2, 30, 140, 3);

		// 컨투어
		vector<vector<Point>> contours;
		vector<vector<Point>> contours2;
		findContours(img_edge, contours, RETR_LIST, CHAIN_APPROX_SIMPLE);
		findContours(img_edge2, contours2, RETR_LIST, CHAIN_APPROX_SIMPLE);

		// roi 영역
		Rect roi(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5);

		// 전체 컨투어 
		for (const auto& contour : contours)
		{
			// 신분증 면적 조건 컨투어 ( 최소한의 크기 이상 지정 )
			if (contourArea(contour) > (300 * 189 * 0.75))
			{
				Rect rect = boundingRect(contour);

				// 가로 세로 비율의 범위 ( 주민등록증 비율 )
				if (abs(1.6 - (double)rect.width / rect.height) <= 0.1)
				{
					// 외각선을 제외한 이미지를 저장하기 위해 roi 복사본인 result
					Mat img_result = img_roi.clone();
					// 주민등록증에 해당하는 윤곽선 표시
					rectangle(img_roi, rect, Scalar(0, 255, 0), 2);

					for (const auto& contour2 : contours2)
					{
						if (contourArea(contour2) > (100 * 125 * 0.75))
						{
							Rect rect2 = boundingRect(contour2);

							if (abs(0.8 - (double)rect2.width / rect2.height) <= 0.2)
							{
								rectangle(img_roi, rect2, Scalar(255, 0, 0), 2);

								// 1초마다 한번 캡쳐하는 조건문
								// contourFound가 flase 일때 ( 주민등록증을 처음으로 찾았을때 )
								if (!contourFound)
								{
									// 현재시점 시간을 start에 저장
									start = chrono::high_resolution_clock::now();
									contourFound = true;
								}
								else
								{
									// 현재시간 시점을 end에 저장
									auto end = chrono::high_resolution_clock::now();
									// end - start = Yees
									chrono::duration<double> Yees = end - start;
									// Yees의 간격이 1초이상일때 저장
									if (Yees.count() >= 1)
									{
										// bounding box 내부의 이미지만 복사 ( 보다 더 깔끔한 이미지를 위해 )
										Mat captured = img_result(rect).clone();

										system("cls");  // 콘솔창 클리어
										char fname[10];
										cout << "저장할 이름을 입력하세요 : ";
										cin >> fname;

										char fnameNum[10];
										sprintf(fnameNum, "%d", num);

										char fname1[70] = "C:\\opencv\\OpenCV_Test1\\OpenCV_Test1\\_internal\\database1\\";
										strcat(fname1, fname);
										strcat(fname1, "_");
										strcat(fname1, fnameNum);
										strcat(fname1, ".jpg");

										char fname2[70] = "C:\\opencv\\OpenCV_Test1\\OpenCV_Test1\\_internal\\database1\\";
										strcat(fname2, fname);
										strcat(fname2, "_");
										strcat(fname2, fnameNum);
										strcat(fname2, ".txt");
										imwrite(fname1, captured);

										std::string gcs_uri = UploadFileToGCS(
											fname1, "hishis9999");

										auto kDefaultUri = gcs_uri;

										if (argc > 2) {
											std::cerr << "Usage: " << argv[0] << " [gcs-uri]\n"
												<< "  The gcs-uri must be in gs://... format. It defaults to "
												<< kDefaultUri << "\n";
											return 1;
										}
										auto uri = std::string{ argc == 2 ? argv[1] : kDefaultUri };

										namespace vision = ::google::cloud::vision_v1;
										auto client =
											vision::ImageAnnotatorClient(vision::MakeImageAnnotatorConnection());

										// Define the image we want to annotate
										google::cloud::vision::v1::Image image;
										image.mutable_source()->set_image_uri(uri);
										// Create a request to annotate this image with Request text annotations for a
										// file stored in GCS.
										google::cloud::vision::v1::AnnotateImageRequest request;
										*request.mutable_image() = std::move(image);
										request.add_features()->set_type(
											google::cloud::vision::v1::Feature::TEXT_DETECTION);

										google::cloud::vision::v1::BatchAnnotateImagesRequest batch_request;
										*batch_request.add_requests() = std::move(request);
										auto batch = client.BatchAnnotateImages(batch_request);
										if (!batch) throw std::move(batch).status();

										// Find the longest annotation and print it
										auto result = std::string{};
										for (auto const& response : batch->responses()) {
											for (auto const& annotation : response.text_annotations()) {
												if (result.size() < annotation.description().size()) {
													result = annotation.description();
												}
											}
										}
										std::cout << "검출된 OCR TEXT" << endl << UTF8ToANSI(result.c_str())
											<< "\n" << endl;
										std::string detectedText = UTF8ToANSI(result.c_str()); // 검출된 텍스트
										string filePath = string(fname2);
										std::ofstream outFile(filePath); // 파일을 연다.
										//std::ofstream outFile(strcat(fname, ".txt")); // 파일을 연다.
										num++;

										if (outFile.is_open()) { // 파일이 성공적으로 열렸는지 확인
											outFile << detectedText; // 텍스트를 파일에 쓴다.
											outFile.close(); // 파일을 닫는다.
										}
										else {
											std::cout << "Unable to open file"; // 파일 열기에 실패한 경우 메시지를 출력
										}
										delete[] pszAnsi;
										cap.release();
										destroyAllWindows();
										return -1;
										contourFound = false;
									}
								}
							}
						}
					}
				}
			}
		}
		// img_video와 같은 크기의 검은색 이미지 생성 ( roi 부분 제외한 나머지 이미지 커트 (한길 의견) )
		Mat img_black = Mat::zeros(img_video.size(), img_video.type());

		// img_video에서 ROI 영역을 검은색 이미지의 같은 위치에 복사 ( 검은색 이미지 추가 )
		img_roi.copyTo(img_black(roi));
		// ROI 영역 위에 한번더 사각형 그리기 ( ROI 영역 강조 )
		rectangle(img_black, Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5), Scalar(0, 0, 255), 2, 4, 0);

		// 확인용 ( ROI 필요 X )
		imshow("ROI", img_roi);     imshow("Video", img_black);     imshow("test", img_edge);

		if (waitKey(1) == 27) { break; } // 키 입력용
	}

}
int ROI2(int argc, char* argv[])
{
	// 캠 실행
	VideoCapture cap(0);
	//VideoCapture cap(0);
	if (!cap.isOpened()) { cout << "실패" << endl;  return -1; }
	Mat img_video, img_capt;

	// chrono 함수의 타이머 계산으로 현재 시간 계산
	// 캡쳐 딜레이 조건을 위한 컨투어 판별
	auto start = chrono::high_resolution_clock::now();
	bool contourFound = false;

	for (;;)
	{
		bool ret = cap.read(img_video);
		if (!ret) { cout << "실패 실패 실패" << endl;  break; }
		if (img_video.empty()) { cout << "영상 실패" << endl;  return -1; }

		int height = img_video.rows, width = img_video.cols;
		int center_x = (int)width * 0.5, center_y = (int)height * 0.5;

		Mat img_roi = img_video(Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5)).clone();
		Mat img_gray, img_edge, img_binary;
		Mat img_gray2, img_edge2, img_binary2;

		// 대충 필터링 죄다 쓰기
		// 주민등록증 전체
		cvtColor(img_roi, img_gray, COLOR_BGR2GRAY);
		GaussianBlur(img_gray, img_gray, Size(5, 5), 0);
		adaptiveThreshold(img_gray, img_binary, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray, img_edge, 30, 140, 3);

		// 주민등록증 사진
		cvtColor(img_roi, img_gray2, COLOR_BGR2GRAY);
		GaussianBlur(img_gray2, img_gray2, Size(5, 5), 0);
		adaptiveThreshold(img_gray2, img_binary2, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray2, img_edge2, 30, 140, 3);

		// 컨투어
		vector<vector<Point>> contours;
		vector<vector<Point>> contours2;
		findContours(img_edge, contours, RETR_LIST, CHAIN_APPROX_SIMPLE);
		findContours(img_edge2, contours2, RETR_LIST, CHAIN_APPROX_SIMPLE);

		// roi 영역
		Rect roi(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5);

		// 전체 컨투어 
		for (const auto& contour : contours)
		{
			// 신분증 면적 조건 컨투어 ( 최소한의 크기 이상 지정 )
			if (contourArea(contour) > (300 * 189 * 0.75))
			{
				Rect rect = boundingRect(contour);

				// 가로 세로 비율의 범위 ( 주민등록증 비율 )
				if (abs(1.6 - (double)rect.width / rect.height) <= 0.1)
				{
					// 외각선을 제외한 이미지를 저장하기 위해 roi 복사본인 result
					Mat img_result = img_roi.clone();
					// 주민등록증에 해당하는 윤곽선 표시
					rectangle(img_roi, rect, Scalar(0, 255, 0), 2);

					for (const auto& contour2 : contours2)
					{
						if (contourArea(contour2) > (100 * 125 * 0.75))
						{
							Rect rect2 = boundingRect(contour2);

							if (abs(0.8 - (double)rect2.width / rect2.height) <= 0.2)
							{
								rectangle(img_roi, rect2, Scalar(255, 0, 0), 2);

								// 1초마다 한번 캡쳐하는 조건문
								// contourFound가 flase 일때 ( 주민등록증을 처음으로 찾았을때 )
								if (!contourFound)
								{
									// 현재시점 시간을 start에 저장
									start = chrono::high_resolution_clock::now();
									contourFound = true;
								}
								else
								{
									// 현재시간 시점을 end에 저장
									auto end = chrono::high_resolution_clock::now();
									// end - start = Yees
									chrono::duration<double> Yees = end - start;
									// Yees의 간격이 1초이상일때 저장
									if (Yees.count() >= 1)
									{
										// bounding box 내부의 이미지만 복사 ( 보다 더 깔끔한 이미지를 위해 )
										Mat captured = img_result(rect).clone();

										system("cls");  // 콘솔창 클리어
										char fname[10];
										cout << "저장할 이름을 입력하세요 : ";
										cin >> fname;

										char fnameNum[10];
										sprintf(fnameNum, "%d", num2);

										char fname1[70] = "C:\\opencv\\OpenCV_Test1\\OpenCV_Test1\\_internal\\database2\\";
										strcat(fname1, fname);
										strcat(fname1, ".jpg");

										char fname2[70] = "C:\\opencv\\OpenCV_Test1\\OpenCV_Test1\\_internal\\database2\\";
										strcat(fname2, fname);
										strcat(fname2, ".txt");
										imwrite(fname1, captured);

										std::string gcs_uri = UploadFileToGCS(
											fname1, "hishis9999");

										auto kDefaultUri = gcs_uri;

										if (argc > 2) {
											std::cerr << "Usage: " << argv[0] << " [gcs-uri]\n"
												<< "  The gcs-uri must be in gs://... format. It defaults to "
												<< kDefaultUri << "\n";
											return 1;
										}
										auto uri = std::string{ argc == 2 ? argv[1] : kDefaultUri };

										namespace vision = ::google::cloud::vision_v1;
										auto client =
											vision::ImageAnnotatorClient(vision::MakeImageAnnotatorConnection());

										// Define the image we want to annotate
										google::cloud::vision::v1::Image image;
										image.mutable_source()->set_image_uri(uri);
										// Create a request to annotate this image with Request text annotations for a
										// file stored in GCS.
										google::cloud::vision::v1::AnnotateImageRequest request;
										*request.mutable_image() = std::move(image);
										request.add_features()->set_type(
											google::cloud::vision::v1::Feature::TEXT_DETECTION);

										google::cloud::vision::v1::BatchAnnotateImagesRequest batch_request;
										*batch_request.add_requests() = std::move(request);
										auto batch = client.BatchAnnotateImages(batch_request);
										if (!batch) throw std::move(batch).status();

										// Find the longest annotation and print it
										auto result = std::string{};
										for (auto const& response : batch->responses()) {
											for (auto const& annotation : response.text_annotations()) {
												if (result.size() < annotation.description().size()) {
													result = annotation.description();
												}
											}
										}system("cls");  // 콘솔창 클리어
										std::cout << "검출된 OCR TEXT"<< endl << UTF8ToANSI(result.c_str())
											<< "\n" << endl;
										std::string detectedText = UTF8ToANSI(result.c_str()); // 검출된 텍스트
										string filePath = string(fname2);
										std::ofstream outFile(filePath); // 파일을 연다.
										//std::ofstream outFile(strcat(fname, ".txt")); // 파일을 연다.
										//num++;
										num2++;


										if (outFile.is_open()) { // 파일이 성공적으로 열렸는지 확인
											outFile << detectedText; // 텍스트를 파일에 쓴다.
											outFile.close(); // 파일을 닫는다.

										}
										else {
											std::cout << "Unable to open file"; // 파일 열기에 실패한 경우 메시지를 출력
										}
										delete[] pszAnsi;
										cap.release();
										destroyAllWindows();
										return -1;
										contourFound = false;
									}
								}
							}
						}
					}
				}
			}
		}
		// img_video와 같은 크기의 검은색 이미지 생성 ( roi 부분 제외한 나머지 이미지 커트 (한길 의견) )
		Mat img_black = Mat::zeros(img_video.size(), img_video.type());

		// img_video에서 ROI 영역을 검은색 이미지의 같은 위치에 복사 ( 검은색 이미지 추가 )
		img_roi.copyTo(img_black(roi));
		// ROI 영역 위에 한번더 사각형 그리기 ( ROI 영역 강조 )
		rectangle(img_black, Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5), Scalar(0, 0, 255), 2, 4, 0);

		// 확인용 ( ROI 필요 X )
		imshow("ROI", img_roi);     imshow("Video", img_black);     imshow("test", img_edge);

		if (waitKey(1) == 27) { break; } // 키 입력용
	}
	/*cap.release();
	destroyAllWindows();*/
}

//이미지 및 텍스트 파일 비교 
void compare_jpg_txt() {
	int match_idt = 0;
	bool compare_jpg = false;
	bool compare_txt = false;
	string base_name;

	//이미지 결과 받기 위한 txt 파일 생성 후, false 써놓기.
	ofstream outFile_img_compare("C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/outfile_img_compare.txt");
	if (outFile_img_compare.is_open())
	{
		outFile_img_compare << "false" << endl;
		outFile_img_compare.close();
	}

	cout << "비교할 신분증 소유자의 이름을 입력하시오." << endl << "이름은 방금 설정하신 이름과 같게 해주세요!" << endl << "입력 : ";
	cin >> base_name;
	cout << endl;
	string folder_path = "C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/";
	string folder_path2 = "C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/";
	string command = {};
	int max_number = distance(directory_iterator(folder_path2), directory_iterator{}) / 2;

	for (int i = 0; i < max_number; ++i) {
		for (const string& ext : { "jpg", "txt" }) {
			string filename1 = folder_path + "database1/" + base_name + "_" + std::to_string(i) + "." + ext;
			string filename2 = folder_path + "database2/" + base_name + "." + ext;

			// exe 파일 뒤에 공백 들어가야함. 단, 열거형 상수관련 오류 때문에 " " 로는 못하고, exe 뒤에 스페이스바로 해결했다.
			command = "C:/opencv/OpenCV_Test1/OpenCV_Test1/main.exe " + filename1 + " " + filename2;

			if (exists(filename1)) {
				//이미지 비교
				if (ext == "jpg")
				{
					string img_compare;
					system(command.c_str());
					system("C:/opencv/OpenCV_Test1/OpenCV_Test1/main.exe");

					//이미지 비교 .exe시스템 종료 후, txt 파일 true됐는지 확인하기
					ifstream inFile_img_compare("C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/outfile_img_compare.txt");
					string img_line;

					if (inFile_img_compare.is_open())
					{ // 파일이 성공적으로 열렸는지 확인
						getline(inFile_img_compare, img_line);
						inFile_img_compare.close(); // 파일 닫기
						if (img_line == "true")
						{
							compare_jpg = true;
						}
						if (img_line == "false")
						{
							compare_jpg = false;
						}
						if (img_line != "true" && img_line != "false")
						{
							cout << "outfile_img_compare.txt 파일에 이상한 문구 이씀! 확인 바람!" << endl;
						}
					}
				}
				//텍스트 비교
				if (ext == "txt")
				{
					//한줄 한줄 불러와서 주민번호(3번째 줄)까지만 불러오려고 벡터 사용
					//파일 읽기 위한 변수와 불러온 텍스트 저장하기 위한 변수 설정
					vector<string> lines1, lines2;
					string line1, line2;
					ifstream input_file1(filename1);
					ifstream input_file2(filename2);
					string test_text1 = {};	
					string test_text2 = {};

					//예외처리(호오오옥시나 못 열까봐)
					if (!input_file1.is_open()) {
						cout << "database1 폴더에서 " << filename1 << "." << ext << " 파일을 열 수 없습니다." << endl;
						break;
					}
					if (!input_file2.is_open()) {
						cout << "database2 폴더에서 " << filename2 << "." << ext << " 파일을 열 수 없습니다." << endl;
						break;
					}

					//연 파일에서 텍스트 읽어와서 텍스트 한 줄씩을 벡터의 한 요소씩에 담기
					while (getline(input_file1, line1)) {
						lines1.push_back(line1);
					}
					while (getline(input_file2, line2)) {
						lines2.push_back(line2);
					}

					//요건 이름에서 한자빼려고 하는거임
					lines1.at(1) = lines1.at(1).substr(0, lines1.at(1).find('('));
					lines2.at(1) = lines2.at(1).substr(0, lines2.at(1).find('('));

					//텍스트를 (3줄까지)변수로 저장. 여기서 줄바꿈 문자까지 있다!
					for (int i = 0; i < 3; i++)
					{
						test_text1 += lines1.at(i).c_str();
						test_text1 += "\n";
						test_text2 += lines2.at(i).c_str();
						test_text2 += "\n";
					}

					//두 파일에서 따온 텍스트 비교
					if (test_text1 == test_text2)
					{
						cout << "텍스트 : 일치" << endl;
						compare_txt = true;
						//cout << ".txt파일의 텍스트가 일치합니다." << endl;
					}
					if (test_text1 != test_text2)
					{
						cout << "텍스트 : 불일치" << endl;
						compare_txt = false;
					}

					input_file1.close();
					input_file2.close();
					//return EXIT_SUCCESS;
				}
				if (ext == "txt" && compare_jpg == true && compare_txt == true)
				{
					cout << "신분증 매칭 성공!" << endl;
					cout << "매칭된 database1 폴더의 jpg 파일 : " << base_name << "_" << std::to_string(i) << ".jpg" << endl;
					cout << "매칭된 database1 폴더의 txt 파일 : " << base_name << "_" << std::to_string(i) << ".txt" << endl << endl;
					match_idt++;
				}
				if (ext == "txt" && (compare_jpg == false || compare_txt == false))
					cout << "신분증 매칭 실패" << endl << endl;
			}
		}
		compare_jpg = false;
		compare_txt = false;
		ofstream outFile_img_compare("C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/outfile_img_compare.txt");
		if (outFile_img_compare.is_open())
		{
			outFile_img_compare << "false" << endl;
			outFile_img_compare.close();
		}
	}
	if (match_idt == 1)
	{
		cout << "신분증 판별이 완료되었습니다!" << endl << "매치된 신분증 : 1개(정상)" << endl;
	}
	if (match_idt == 0)
	{
		cout << "신분증 판별이 완료되었습니다!" << endl << "매치된 신분증이 없습니다!" << endl
			<< "인식한 신분증이 데이터베이스에 먼저 등록이 된 신분증인지 확인해주세요." << endl;
	}
	if (match_idt != 1 && match_idt != 0)
		cout << "신분증 판별이 불가합니다. 데이터베이스에 해당 '신분증의 정보가 여러 개'인지 확인해주세요." << endl;
}

int main(int argc, char* argv[])    try {

	while (1) {

		int input_number;
		char input_str[100] = {};
		print_1();
		cin >> input_number;

		switch (input_number) {
		case 1:
			ROI1(argc, argv);
			Sleep(1500);
			cout << "저장되었습니다." << endl;
			//cap.release();
			destroyAllWindows();
			Sleep(1500);
			break;
		case 2:
			ROI2(argc, argv);
			compare_jpg_txt();
			cout << "초기 화면으로 돌아가려면 아무 문자나 입력 후 Enter" << endl << "입력 : ";
			//cap.release();
			cin >> input_str;
			if (input_str != "")
			{
				destroyAllWindows();
				break;
			}
		case 3:
			break;
		default:
			cout << "잘못된 입력입니다." << endl;
		}
		if (input_number == 3)
		{
			break;
		}
	}
	//txt_comparison();
	//compareFiles();
}
catch (google::cloud::Status const& status) {
	std::cerr << "google::cloud::Status thrown: " << status << "\n";
	return 1;
}