using Group5_TeamProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Winform_TeamProject
{
    public partial class Form_Moble : Form
    {
        static public List<string> moble_commu = new List<string>();

        int moble_text_index = 0;
        Bitmap Student = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\student-remove.png");
        Bitmap Professor = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\Professor after-remove.png");
        Bitmap Student_bro = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\student_bro-remove.png");
        Bitmap bro = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\bro-remove.png");
        Bitmap Left_police_officer = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\left_police_officer.png");
        Bitmap Right_police_officer = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\right_police_officer.png");
        Bitmap Students = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\students-remove.png");
        Bitmap Under_floor = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\Under_floor.jpg");
        Bitmap Academy = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\academy.png");
        Bitmap First_floor = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\First_Floor.jpg");
        Bitmap TheEnd = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project4_image\clear_image.png");
        private bool isProcessing = false;

        public Form_Moble()
        {
            this.BackgroundImage = First_floor;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            moble_commu.Add("(드디어 학원에 도착했다.)");
            moble_commu.Add("도착이다!");
            moble_commu.Add("휴~ 오는 동안 정말 많은 일이 있었네~");
            moble_commu.Add("...");
            moble_commu.Add("(앞에 먼저 건물에 도착한 학생이 보인다.)");
            /*5*/
            moble_commu.Add("어? 태운이니?");
            moble_commu.Add("(반가운 마음에 다가가 인사를 건네지만 \n그는 누가봐도 수상한 사람과 함께 계단을 내려간다.)");
            moble_commu.Add("학생이.. 무시..?\n(옆에 있는 사람은 누구지? 처음 보는 것 같은데...)");
            moble_commu.Add("(먼저 올라가야겠다.\n우리 학원은 3층인데.. 이상하네 왜 내려가지?)");
            moble_commu.Add("System : 엘리베이터에 탑승합니다.");
            /*10*/
            moble_commu.Add("System : 학원에 입장하였습니다.");    //배경 바꾸기(학원)
            moble_commu.Add("(학생이 아무도 없다.)");
            moble_commu.Add("어? 시간이 몇신데 아무도 없지..? (무언가 이상하다.)");
            moble_commu.Add("(학생들이 모두 연락을 받지 않는다.)");
            moble_commu.Add("아까 계단으로 내려간 태운이를 찾으러 가봐야하나?");
            /*15*/
            moble_commu.Add("System : 지하 1층을 가보시겠습니까?");     //y/n 버튼 만들기
            moble_commu.Add("아니다. 10분만 기다려보자.");
            moble_commu.Add("System : 10분 경과 후...");
            moble_commu.Add("(안되겠다! 내려가보자!)");
            moble_commu.Add("System : 지하로 내려갑니다.");
            /*20*/
            moble_commu.Add("(내려오자마자 큰 철문이 보인다. 확인해보자.)");  //배경 바꾸기(지하)
            moble_commu.Add("알아들었어!? 너네는 그냥 배달만 하면 돼!\n실수하면.. 알지?");   //마약 브로커 캐릭터 대사 
            moble_commu.Add("(누군가가 학생들을 위협하고 있다. 배달이라니, 혹시.. 마약..?)");
            moble_commu.Add("System : 이 곳은 마약을 밀수해 국내에서 마약거래를 하는 조직입니다.");
            moble_commu.Add("System : 어떻게 하시겠습니까?");    // 경찰에 신고 or 도망 버튼
            /*25*/
            moble_commu.Add("System : 다시 지하로 내려갑니다.");
            moble_commu.Add("(일단 경찰에 신고하자..!)");
            moble_commu.Add("System : 경찰에 신고하려면 증거가 필요합니다.\n증거를 찾으세요.");
            moble_commu.Add(""); //브로커의 콤퓨타 이벤트 발생
            moble_commu.Add("System : 증거를 확보했습니다. 안전을 확보하고 112에 전화하세요.");
            /*30*/
            moble_commu.Add("(일단 1층으로 다시 올라가자.)");  //30
            moble_commu.Add("System : 1층으로 올라갑니다.");
            moble_commu.Add("(1층에 도착했다. 112에 전화해보자.)"); //배경 바꾸기(다시 1층)
            moble_commu.Add("System : 112에 전화를 연결합니다.\n(♬ 아기 상어~ 뚜루루 뚜루~...)");
            moble_commu.Add("네. 112입니다. 무엇을 도와드릴까요?");  //경찰 대사
            /*35*/
            moble_commu.Add("여기 ~~인데요. 지금 지하 1층에서 학원 학생들을 데리고 \n마약 거래를 시키려고 해요!" +
                " 바로 출동 가능한가요?");
            moble_commu.Add("네. 바로 출동하겠습니다! 마약 거래의 증거가 될만한 게 있을까요?");     //경찰 대사
            moble_commu.Add("장부 확보 했습니다!");
            moble_commu.Add("네. 안전한 곳으로 일단 몸을 숨기세요!");  //경찰 대사
            moble_commu.Add("System : 전화 연결을 종료합니다.");
            /*40*/
            moble_commu.Add("(좋아. 이제 안전한 곳으로 잠시 몸을 피하자!)");
            moble_commu.Add("System :10분 경과 후...");
            moble_commu.Add("(저기 경찰이 보인다!)");
            moble_commu.Add("신고자분 맞으신가요!?");    //경찰 대사
            moble_commu.Add("네! 여기 지하 1층이에요! 여기 장부가 담긴 USB에요!");
            /*45*/
            moble_commu.Add("System : USB를 넘깁니다."); //USB 넘기면 인벤토리 리스트에서 usb 삭제
            moble_commu.Add("잘하셨어요! 여기 잠시 계세요!");  //경찰 대사
            moble_commu.Add("System : 잠시 후 지하에선 ...");  // 지하 배경
            moble_commu.Add("꼼작 마! 이 쉐리들아! 쏠 수 이써~");   //경찰 대사(여기서부터는 경찰을 PictureBox1에!(왼쪽에!)) 
            moble_commu.Add("헉!! 경찰!?");     //브로커 대사
            /*50*/
            moble_commu.Add("당신을 마약류 유통 및 관리에 관한 법률 위반으로 체포합니다!\n(대충 미란다 원칙)"); //경찰 대사
            moble_commu.Add("아 이걸 걸리네 ㅎㅎ;;");   //브로커
            moble_commu.Add("얘들아 괜찮닝? 어헝헝 너네 잘못되는줄 알았어어!"); // 교수님 띄우기
            moble_commu.Add("교수님 ㅠㅠ. 흐엉 ㅜㅜ.");  //태운 및 학생들(태운 사진 여러장 가능?)
            moble_commu.Add("(무사히 아이들을 지켜냈다! 역시 난 급나 멋진 교육자야!)");
            /*55*/
            moble_commu.Add("신고해주셔서 감사합니다. 최근에 찾고 있던 조직이였거든요.");   //경찰 대사
            moble_commu.Add("잘 해결되어서 다행입니다.");
            moble_commu.Add("아이들을 무사히 구해주셔서 감사합니다."); // 경찰 대사
            moble_commu.Add("그럼 저희는 이만 연행하도록 하겠습니다.\n (동료에게)얼른 가자.");
            moble_commu.Add("System : 사건을 해결하였습니다.");   // 이 후 장면 전환
            /*60*/
            moble_commu.Add(". . . .");
            moble_commu.Add(". . . .");
            moble_commu.Add(". . . .");
            moble_commu.Add("교수님. 그럼 이제 저희 다 돌아가서 심신의 안정을 취하면 되나요?!");  //태운 및 학생들 // 학원
            moble_commu.Add("무씬 소리야? 진도 나가야지? 오늘까지 C#이랑 윈폼 다 끝내야하는데..?");   //공포테마??
            /*65*/
            moble_commu.Add("ㅎㅎ?..");   //태운 및 학생들
            moble_commu.Add("에..?");    //22
            moble_commu.Add("꺄아아아악!!!");  //33
            moble_commu.Add("(그렇게 무사히 수업을 마친 그들이었다.)");
            //fin >> 같은 폼에서 pictureBox로 The End 사진 나타내기 > timer1
        }
        private async Task DisplayTextWithDelay(string text, Label label, int delay)
        {
            for (int i = 0; i < text.Length; i++)
            {
                label.Text += text[i].ToString();
                await Task.Delay(delay);
            }
        }

        private void btn_GoEvent1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("브로커의 방으로 이동합니다");
            MessageBox.Show("증거 찾기 : 컴퓨터를 비밀번호를 풀고 \n증거를 찾으세요!");
            Form_MobleEvent form_MobleEvent = new Form_MobleEvent();
            form_MobleEvent.Show();
        }

        private async void Text_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            bool success_computer_event1 = Form_Moble_ComputerScreen.success_computer_event2;
            if (isProcessing)
            {
                return;
            }

            if (moble_text_index == 4)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = Student;
            }

            if (moble_text_index == 5 || moble_text_index == 7 || moble_text_index == 21)
            {
                pictureBox2.Image = null;
                pictureBox1.Image = Professor;
            }

            if (moble_text_index == 6)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = Student_bro;
            }

            if (moble_text_index == 10)
            {
                this.BackgroundImage = null;
                this.BackgroundImage = Academy;
            }
            if (moble_text_index == 15)
            {
                btn_commu_yes.Visible = true;
                btn_commu15_no.Visible = true;
                return; // 버튼 안눌리면 다음 텍스트 안뜨게 하기
            }
            if (moble_text_index == 20)
            {
                this.BackgroundImage = null;
                this.BackgroundImage = Under_floor;
            }
            if (moble_text_index == 21 || moble_text_index == 49 || moble_text_index == 51)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = bro;
            }

            if (moble_text_index == 11 || moble_text_index == 16 || moble_text_index == 18 || moble_text_index == 20 ||
                moble_text_index == 22 || moble_text_index == 26 || moble_text_index == 30 || moble_text_index == 32 ||
                moble_text_index == 35 || moble_text_index == 37 || moble_text_index == 39 || moble_text_index == 40 ||
                moble_text_index == 42 || moble_text_index == 44 || moble_text_index == 52 || moble_text_index == 54 ||
                moble_text_index == 56 || moble_text_index == 64)
            {
                pictureBox1.Image = Professor;
                pictureBox2.Image = null;
            }

            if (moble_text_index == 24)
            {
                btn_run.Visible = true;
                btn_Call_911.Visible = true;
                return;
            }

            if (moble_text_index == 28)
            {
                btn_Search.Visible = true;
                if (success_computer_event1 == true)
                {
                    moble_text_index = 29;
                    btn_Search.Visible = false;
                }
                return;
            }

            if (moble_text_index == 29)
            {
                btn_Search.Visible = false;
            }
            if (moble_text_index == 32)
            {
                this.BackgroundImage = null;
                this.BackgroundImage = First_floor;
            }

            if (moble_text_index == 34 || moble_text_index == 36 || moble_text_index == 38 || moble_text_index == 43 ||
                moble_text_index == 46 || moble_text_index == 55 || moble_text_index == 57)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = Right_police_officer;
            }

            if (moble_text_index == 48 || moble_text_index == 50)
            {
                pictureBox1.Image = Left_police_officer;
                pictureBox2.Image = null;
            }
            if (moble_text_index == 47)
            {
                this.BackgroundImage = null;
                this.BackgroundImage = Under_floor;
            }

            if (moble_text_index == 9 || moble_text_index == 15 || moble_text_index == 17 || moble_text_index == 19
                || moble_text_index == 23 || moble_text_index == 27 || moble_text_index == 31 || moble_text_index == 33
                || moble_text_index == 39 || moble_text_index == 41 || moble_text_index == 45 || moble_text_index == 47
                || moble_text_index == 59)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = null;
            }
            if (moble_text_index == 53 || moble_text_index == 63 || moble_text_index == 65)
            {
                pictureBox1.Image = null;
                pictureBox2.Image = Students;
            }
            if (moble_text_index == 68)
            {
                pictureBox1.Image = Professor;
                pictureBox2.Image = Students;
            }
            if (moble_text_index == 69)     // 게임 클리어한 창 > The End 창 pictureBox로 띄우기.
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                Text_Panel.Visible = false;
                this.BackgroundImage = TheEnd;
                btn_Exit.Location = new Point(531, 419);
            }

            if (moble_text_index + 1 <= moble_commu.Count)
            {
                string text = moble_commu[moble_text_index];
                moble_text_index++;

                isProcessing = true;
                await ProcessText(text);
                isProcessing = false;
            }
        }

        private async Task ProcessText(string text)
        {
            label1.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += text[i].ToString();
                await Task.Delay(10);
            }
        }

        private void btn_commu_yes_Click(object sender, EventArgs e)
        {
            btn_commu_yes.Visible = false;
            btn_commu15_no.Visible = false;
            MessageBox.Show("지하로 내려갑니다.");
            moble_text_index = 19;
        }

        private void btn_commu15_no_Click(object sender, EventArgs e)
        {
            btn_commu_yes.Visible = false;
            btn_commu15_no.Visible = false;
            //MessageBox.Show("지하로 내려가지 않습니다.");
            moble_text_index = 16;


        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            btn_run.Visible = false;
            btn_Call_911.Visible = false;
            MessageBox.Show("지하에서 빠져나옵니다.");
            // 배경 바꾸는 코드 넣기

            label1.Text = "아니야, 그래도 나는 교수니까 학생들을 구하러 가자!";

            moble_text_index = 25;
            if (label1.Text == " ")
            {
                MessageBox.Show("다시 지하로 돌아갑니다.");
            }
            // 배경 다시 지하로 바꾸기

        }

        private void btn_Call_911_Click(object sender, EventArgs e)
        {
            btn_run.Visible = false;
            btn_Call_911.Visible = false;
            MessageBox.Show("경찰에 신고하려면 증거가 필요합니다!");
            moble_text_index = 27;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}

