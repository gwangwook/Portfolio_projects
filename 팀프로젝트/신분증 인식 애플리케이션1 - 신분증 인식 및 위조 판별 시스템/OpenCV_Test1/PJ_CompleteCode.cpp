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

//���ڵ� ���ִ� �κ�
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
void print_1()      // �ܼ� �޴� ��¿�
{
	Sleep(500);     // ������ ��¹� ���ð�
	system("cls");  // �ܼ�â Ŭ����
	cout << "************** < �ź��� ���� �� ���� ���� ���α׷� > **************" << endl
		<< "*     1. �ź��� ����						  *" << endl
		<< "*     2. �ź��� ��						  *" << endl
		<< "*     3. �����ϱ�						  *" << endl
		<< "*******************************************************************" << endl
		<< "�޴� ��ȣ�� �Է��ϼ���: ";
}

//��ķ ���� �κ�, �޴� 1�� = ROI1, �޴� 2�� = ROI2
int ROI1(int argc, char* argv[])
{
	// ķ ����
	VideoCapture cap(0);
	if (!cap.isOpened()) { cout << "����" << endl;  return -1; }
	Mat img_video, img_capt;

	// chrono �Լ��� Ÿ�̸� ������� ���� �ð� ���
	// ĸ�� ������ ������ ���� ������ �Ǻ�
	auto start = chrono::high_resolution_clock::now();
	bool contourFound = false;

	for (;;)
	{
		bool ret = cap.read(img_video);
		if (!ret) { cout << "���� ���� ����" << endl;  break; }
		if (img_video.empty()) { cout << "���� ����" << endl;  return -1; }

		int height = img_video.rows, width = img_video.cols;
		int center_x = (int)width * 0.5, center_y = (int)height * 0.5;

		Mat img_roi = img_video(Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5)).clone();
		Mat img_gray, img_edge, img_binary;
		Mat img_gray2, img_edge2, img_binary2;

		// ���� ���͸� �˴� ����
		// �ֹε���� ��ü
		cvtColor(img_roi, img_gray, COLOR_BGR2GRAY);
		GaussianBlur(img_gray, img_gray, Size(5, 5), 0);
		adaptiveThreshold(img_gray, img_binary, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray, img_edge, 30, 140, 3);

		// �ֹε���� ����
		cvtColor(img_roi, img_gray2, COLOR_BGR2GRAY);
		GaussianBlur(img_gray2, img_gray2, Size(5, 5), 0);
		adaptiveThreshold(img_gray2, img_binary2, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray2, img_edge2, 30, 140, 3);

		// ������
		vector<vector<Point>> contours;
		vector<vector<Point>> contours2;
		findContours(img_edge, contours, RETR_LIST, CHAIN_APPROX_SIMPLE);
		findContours(img_edge2, contours2, RETR_LIST, CHAIN_APPROX_SIMPLE);

		// roi ����
		Rect roi(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5);

		// ��ü ������ 
		for (const auto& contour : contours)
		{
			// �ź��� ���� ���� ������ ( �ּ����� ũ�� �̻� ���� )
			if (contourArea(contour) > (300 * 189 * 0.75))
			{
				Rect rect = boundingRect(contour);

				// ���� ���� ������ ���� ( �ֹε���� ���� )
				if (abs(1.6 - (double)rect.width / rect.height) <= 0.1)
				{
					// �ܰ����� ������ �̹����� �����ϱ� ���� roi ���纻�� result
					Mat img_result = img_roi.clone();
					// �ֹε������ �ش��ϴ� ������ ǥ��
					rectangle(img_roi, rect, Scalar(0, 255, 0), 2);

					for (const auto& contour2 : contours2)
					{
						if (contourArea(contour2) > (100 * 125 * 0.75))
						{
							Rect rect2 = boundingRect(contour2);

							if (abs(0.8 - (double)rect2.width / rect2.height) <= 0.2)
							{
								rectangle(img_roi, rect2, Scalar(255, 0, 0), 2);

								// 1�ʸ��� �ѹ� ĸ���ϴ� ���ǹ�
								// contourFound�� flase �϶� ( �ֹε������ ó������ ã������ )
								if (!contourFound)
								{
									// ������� �ð��� start�� ����
									start = chrono::high_resolution_clock::now();
									contourFound = true;
								}
								else
								{
									// ����ð� ������ end�� ����
									auto end = chrono::high_resolution_clock::now();
									// end - start = Yees
									chrono::duration<double> Yees = end - start;
									// Yees�� ������ 1���̻��϶� ����
									if (Yees.count() >= 1)
									{
										// bounding box ������ �̹����� ���� ( ���� �� ����� �̹����� ���� )
										Mat captured = img_result(rect).clone();

										system("cls");  // �ܼ�â Ŭ����
										char fname[10];
										cout << "������ �̸��� �Է��ϼ��� : ";
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
										std::cout << "����� OCR TEXT" << endl << UTF8ToANSI(result.c_str())
											<< "\n" << endl;
										std::string detectedText = UTF8ToANSI(result.c_str()); // ����� �ؽ�Ʈ
										string filePath = string(fname2);
										std::ofstream outFile(filePath); // ������ ����.
										//std::ofstream outFile(strcat(fname, ".txt")); // ������ ����.
										num++;

										if (outFile.is_open()) { // ������ ���������� ���ȴ��� Ȯ��
											outFile << detectedText; // �ؽ�Ʈ�� ���Ͽ� ����.
											outFile.close(); // ������ �ݴ´�.
										}
										else {
											std::cout << "Unable to open file"; // ���� ���⿡ ������ ��� �޽����� ���
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
		// img_video�� ���� ũ���� ������ �̹��� ���� ( roi �κ� ������ ������ �̹��� ĿƮ (�ѱ� �ǰ�) )
		Mat img_black = Mat::zeros(img_video.size(), img_video.type());

		// img_video���� ROI ������ ������ �̹����� ���� ��ġ�� ���� ( ������ �̹��� �߰� )
		img_roi.copyTo(img_black(roi));
		// ROI ���� ���� �ѹ��� �簢�� �׸��� ( ROI ���� ���� )
		rectangle(img_black, Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5), Scalar(0, 0, 255), 2, 4, 0);

		// Ȯ�ο� ( ROI �ʿ� X )
		imshow("ROI", img_roi);     imshow("Video", img_black);     imshow("test", img_edge);

		if (waitKey(1) == 27) { break; } // Ű �Է¿�
	}

}
int ROI2(int argc, char* argv[])
{
	// ķ ����
	VideoCapture cap(0);
	//VideoCapture cap(0);
	if (!cap.isOpened()) { cout << "����" << endl;  return -1; }
	Mat img_video, img_capt;

	// chrono �Լ��� Ÿ�̸� ������� ���� �ð� ���
	// ĸ�� ������ ������ ���� ������ �Ǻ�
	auto start = chrono::high_resolution_clock::now();
	bool contourFound = false;

	for (;;)
	{
		bool ret = cap.read(img_video);
		if (!ret) { cout << "���� ���� ����" << endl;  break; }
		if (img_video.empty()) { cout << "���� ����" << endl;  return -1; }

		int height = img_video.rows, width = img_video.cols;
		int center_x = (int)width * 0.5, center_y = (int)height * 0.5;

		Mat img_roi = img_video(Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5)).clone();
		Mat img_gray, img_edge, img_binary;
		Mat img_gray2, img_edge2, img_binary2;

		// ���� ���͸� �˴� ����
		// �ֹε���� ��ü
		cvtColor(img_roi, img_gray, COLOR_BGR2GRAY);
		GaussianBlur(img_gray, img_gray, Size(5, 5), 0);
		adaptiveThreshold(img_gray, img_binary, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray, img_edge, 30, 140, 3);

		// �ֹε���� ����
		cvtColor(img_roi, img_gray2, COLOR_BGR2GRAY);
		GaussianBlur(img_gray2, img_gray2, Size(5, 5), 0);
		adaptiveThreshold(img_gray2, img_binary2, 255, ADAPTIVE_THRESH_GAUSSIAN_C, THRESH_BINARY, 11, 2);
		Canny(img_gray2, img_edge2, 30, 140, 3);

		// ������
		vector<vector<Point>> contours;
		vector<vector<Point>> contours2;
		findContours(img_edge, contours, RETR_LIST, CHAIN_APPROX_SIMPLE);
		findContours(img_edge2, contours2, RETR_LIST, CHAIN_APPROX_SIMPLE);

		// roi ����
		Rect roi(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5);

		// ��ü ������ 
		for (const auto& contour : contours)
		{
			// �ź��� ���� ���� ������ ( �ּ����� ũ�� �̻� ���� )
			if (contourArea(contour) > (300 * 189 * 0.75))
			{
				Rect rect = boundingRect(contour);

				// ���� ���� ������ ���� ( �ֹε���� ���� )
				if (abs(1.6 - (double)rect.width / rect.height) <= 0.1)
				{
					// �ܰ����� ������ �̹����� �����ϱ� ���� roi ���纻�� result
					Mat img_result = img_roi.clone();
					// �ֹε������ �ش��ϴ� ������ ǥ��
					rectangle(img_roi, rect, Scalar(0, 255, 0), 2);

					for (const auto& contour2 : contours2)
					{
						if (contourArea(contour2) > (100 * 125 * 0.75))
						{
							Rect rect2 = boundingRect(contour2);

							if (abs(0.8 - (double)rect2.width / rect2.height) <= 0.2)
							{
								rectangle(img_roi, rect2, Scalar(255, 0, 0), 2);

								// 1�ʸ��� �ѹ� ĸ���ϴ� ���ǹ�
								// contourFound�� flase �϶� ( �ֹε������ ó������ ã������ )
								if (!contourFound)
								{
									// ������� �ð��� start�� ����
									start = chrono::high_resolution_clock::now();
									contourFound = true;
								}
								else
								{
									// ����ð� ������ end�� ����
									auto end = chrono::high_resolution_clock::now();
									// end - start = Yees
									chrono::duration<double> Yees = end - start;
									// Yees�� ������ 1���̻��϶� ����
									if (Yees.count() >= 1)
									{
										// bounding box ������ �̹����� ���� ( ���� �� ����� �̹����� ���� )
										Mat captured = img_result(rect).clone();

										system("cls");  // �ܼ�â Ŭ����
										char fname[10];
										cout << "������ �̸��� �Է��ϼ��� : ";
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
										}system("cls");  // �ܼ�â Ŭ����
										std::cout << "����� OCR TEXT"<< endl << UTF8ToANSI(result.c_str())
											<< "\n" << endl;
										std::string detectedText = UTF8ToANSI(result.c_str()); // ����� �ؽ�Ʈ
										string filePath = string(fname2);
										std::ofstream outFile(filePath); // ������ ����.
										//std::ofstream outFile(strcat(fname, ".txt")); // ������ ����.
										//num++;
										num2++;


										if (outFile.is_open()) { // ������ ���������� ���ȴ��� Ȯ��
											outFile << detectedText; // �ؽ�Ʈ�� ���Ͽ� ����.
											outFile.close(); // ������ �ݴ´�.

										}
										else {
											std::cout << "Unable to open file"; // ���� ���⿡ ������ ��� �޽����� ���
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
		// img_video�� ���� ũ���� ������ �̹��� ���� ( roi �κ� ������ ������ �̹��� ĿƮ (�ѱ� �ǰ�) )
		Mat img_black = Mat::zeros(img_video.size(), img_video.type());

		// img_video���� ROI ������ ������ �̹����� ���� ��ġ�� ���� ( ������ �̹��� �߰� )
		img_roi.copyTo(img_black(roi));
		// ROI ���� ���� �ѹ��� �簢�� �׸��� ( ROI ���� ���� )
		rectangle(img_black, Rect(center_x - 150 * 1.5, center_y - 95 * 1.5, 300 * 1.5, 189 * 1.5), Scalar(0, 0, 255), 2, 4, 0);

		// Ȯ�ο� ( ROI �ʿ� X )
		imshow("ROI", img_roi);     imshow("Video", img_black);     imshow("test", img_edge);

		if (waitKey(1) == 27) { break; } // Ű �Է¿�
	}
	/*cap.release();
	destroyAllWindows();*/
}

//�̹��� �� �ؽ�Ʈ ���� �� 
void compare_jpg_txt() {
	int match_idt = 0;
	bool compare_jpg = false;
	bool compare_txt = false;
	string base_name;

	//�̹��� ��� �ޱ� ���� txt ���� ���� ��, false �����.
	ofstream outFile_img_compare("C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/outfile_img_compare.txt");
	if (outFile_img_compare.is_open())
	{
		outFile_img_compare << "false" << endl;
		outFile_img_compare.close();
	}

	cout << "���� �ź��� �������� �̸��� �Է��Ͻÿ�." << endl << "�̸��� ��� �����Ͻ� �̸��� ���� ���ּ���!" << endl << "�Է� : ";
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

			// exe ���� �ڿ� ���� ������. ��, ������ ������� ���� ������ " " �δ� ���ϰ�, exe �ڿ� �����̽��ٷ� �ذ��ߴ�.
			command = "C:/opencv/OpenCV_Test1/OpenCV_Test1/main.exe " + filename1 + " " + filename2;

			if (exists(filename1)) {
				//�̹��� ��
				if (ext == "jpg")
				{
					string img_compare;
					system(command.c_str());
					system("C:/opencv/OpenCV_Test1/OpenCV_Test1/main.exe");

					//�̹��� �� .exe�ý��� ���� ��, txt ���� true�ƴ��� Ȯ���ϱ�
					ifstream inFile_img_compare("C:/opencv/OpenCV_Test1/OpenCV_Test1/_internal/database1/outfile_img_compare.txt");
					string img_line;

					if (inFile_img_compare.is_open())
					{ // ������ ���������� ���ȴ��� Ȯ��
						getline(inFile_img_compare, img_line);
						inFile_img_compare.close(); // ���� �ݱ�
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
							cout << "outfile_img_compare.txt ���Ͽ� �̻��� ���� �̾�! Ȯ�� �ٶ�!" << endl;
						}
					}
				}
				//�ؽ�Ʈ ��
				if (ext == "txt")
				{
					//���� ���� �ҷ��ͼ� �ֹι�ȣ(3��° ��)������ �ҷ������� ���� ���
					//���� �б� ���� ������ �ҷ��� �ؽ�Ʈ �����ϱ� ���� ���� ����
					vector<string> lines1, lines2;
					string line1, line2;
					ifstream input_file1(filename1);
					ifstream input_file2(filename2);
					string test_text1 = {};	
					string test_text2 = {};

					//����ó��(ȣ�������ó� �� �����)
					if (!input_file1.is_open()) {
						cout << "database1 �������� " << filename1 << "." << ext << " ������ �� �� �����ϴ�." << endl;
						break;
					}
					if (!input_file2.is_open()) {
						cout << "database2 �������� " << filename2 << "." << ext << " ������ �� �� �����ϴ�." << endl;
						break;
					}

					//�� ���Ͽ��� �ؽ�Ʈ �о�ͼ� �ؽ�Ʈ �� �پ��� ������ �� ��Ҿ��� ���
					while (getline(input_file1, line1)) {
						lines1.push_back(line1);
					}
					while (getline(input_file2, line2)) {
						lines2.push_back(line2);
					}

					//��� �̸����� ���ڻ����� �ϴ°���
					lines1.at(1) = lines1.at(1).substr(0, lines1.at(1).find('('));
					lines2.at(1) = lines2.at(1).substr(0, lines2.at(1).find('('));

					//�ؽ�Ʈ�� (3�ٱ���)������ ����. ���⼭ �ٹٲ� ���ڱ��� �ִ�!
					for (int i = 0; i < 3; i++)
					{
						test_text1 += lines1.at(i).c_str();
						test_text1 += "\n";
						test_text2 += lines2.at(i).c_str();
						test_text2 += "\n";
					}

					//�� ���Ͽ��� ���� �ؽ�Ʈ ��
					if (test_text1 == test_text2)
					{
						cout << "�ؽ�Ʈ : ��ġ" << endl;
						compare_txt = true;
						//cout << ".txt������ �ؽ�Ʈ�� ��ġ�մϴ�." << endl;
					}
					if (test_text1 != test_text2)
					{
						cout << "�ؽ�Ʈ : ����ġ" << endl;
						compare_txt = false;
					}

					input_file1.close();
					input_file2.close();
					//return EXIT_SUCCESS;
				}
				if (ext == "txt" && compare_jpg == true && compare_txt == true)
				{
					cout << "�ź��� ��Ī ����!" << endl;
					cout << "��Ī�� database1 ������ jpg ���� : " << base_name << "_" << std::to_string(i) << ".jpg" << endl;
					cout << "��Ī�� database1 ������ txt ���� : " << base_name << "_" << std::to_string(i) << ".txt" << endl << endl;
					match_idt++;
				}
				if (ext == "txt" && (compare_jpg == false || compare_txt == false))
					cout << "�ź��� ��Ī ����" << endl << endl;
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
		cout << "�ź��� �Ǻ��� �Ϸ�Ǿ����ϴ�!" << endl << "��ġ�� �ź��� : 1��(����)" << endl;
	}
	if (match_idt == 0)
	{
		cout << "�ź��� �Ǻ��� �Ϸ�Ǿ����ϴ�!" << endl << "��ġ�� �ź����� �����ϴ�!" << endl
			<< "�ν��� �ź����� �����ͺ��̽��� ���� ����� �� �ź������� Ȯ�����ּ���." << endl;
	}
	if (match_idt != 1 && match_idt != 0)
		cout << "�ź��� �Ǻ��� �Ұ��մϴ�. �����ͺ��̽��� �ش� '�ź����� ������ ���� ��'���� Ȯ�����ּ���." << endl;
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
			cout << "����Ǿ����ϴ�." << endl;
			//cap.release();
			destroyAllWindows();
			Sleep(1500);
			break;
		case 2:
			ROI2(argc, argv);
			compare_jpg_txt();
			cout << "�ʱ� ȭ������ ���ư����� �ƹ� ���ڳ� �Է� �� Enter" << endl << "�Է� : ";
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
			cout << "�߸��� �Է��Դϴ�." << endl;
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