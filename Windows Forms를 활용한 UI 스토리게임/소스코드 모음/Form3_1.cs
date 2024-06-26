using Group5_TeamProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_TeamProject;

namespace _3_1
{
    public partial class Form3_1 : Form
    {
        static public List<string> str = new List<string>();
        static public int a = 0;   //문자열
        int check3_2 = 0;  //둥지식당 골목길 방향 체크
        int check3_3 = 0;  //신호등 방향 체크
        Image image_dungji = Image.FromFile(@"C:\C#\WinForm_TeamProject_Group5\project3_image\golmok1.png");
        Image image_sinho = Image.FromFile(@"C:\C#\WinForm_TeamProject_Group5\project3_image\sinho_7.png");
        Image image_teacher = Image.FromFile(@"C:\C#\WinForm_TeamProject_Group5\project3_image\char1-removebg-preview.png");
        Image image_billon = Image.FromFile(@"C:\C#\WinForm_TeamProject_Group5\project3_image\image2.gif");
        bool b_Headset = false;   //헤드셋 판단 임시 bool 변수
        public static bool b_event_Check = false;
        public static bool b_gameover_Check = false;
        Random random_situation = new Random();  //어느 빌런 만날지 랜덤
        int ran_dunji = 0;  //랜덤 변수
        int ran_sinho = 0;
        private bool isProcessing = false;

        public Form3_1()
        {
            InitializeComponent();
            str.Add("드디어 도착!!!");
            str.Add("학원으로 가보자 \n이제 어느 방향으로 갈까?");
            str.Add("System: 어느길로 갈지 선택한다."); //a == 2;
            str.Add("..."); //a==3
            ran_dunji = random_situation.Next(0, 4); //무서운아저씨, 사이비, 롱패딩바바리안, 안만날때
            ran_sinho = random_situation.Next(0, 3); //깡다구사장, 모블학생, 안만날때

            if (Form_MainStory_Home.Inventory.Contains("헤드셋"))
            {
                b_Headset = true;
            }
            //b_Headset = false;
        }

        private async Task DisplayTextWithDelay(string text, Label label, int delay)
        {
            for (int i = 0; i < text.Length; i++)
            {
                label.Text += text[i].ToString();
                await Task.Delay(delay);
            }

        }
        private void btn3_2_Click(object sender, EventArgs e)  //글만 적이 or 버튼 이미지(방향 화살표) 도 넣어보기 
        {
            this.BackgroundImage = image_dungji;
            btn3_2.Visible = false;
            btn3_3.Visible = false;
            check3_2 = 1;

        }
        private void btn3_3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = image_sinho;
            btn3_2.Visible = false;
            btn3_3.Visible = false;
            check3_3 = 1;
        }

        private async void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            bool event_Check = b_event_Check;
            bool gameover_check = b_gameover_Check;
            if (a == 2 && check3_2 == 0 && check3_3 == 0)//&& check == 0)
            {
                btn3_2.Visible = true;
                btn3_3.Visible = true;
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                return;
            }
            if (a == 2 && check3_2 == 1)         //둥지식당 골목길
            {
                a++;
                pictureBox1.Image = image_teacher;
                str.Add("오늘은 골목길로 가보자!");
            }
            if (a == 2 && check3_3 == 1)         //신호등
            {
                a++;
                pictureBox1.Image = image_teacher;
                str.Add("오늘은 신호등으로 가보자!");
            }
            if (b_Headset == true)   //헤드셋 있을때 상황 + 둥지식당 골목길 //if(Form_Inventori.Equ2.Image != null)
            {
                if ((a == 8 && check3_2 == 1 && ran_dunji == 0) || (a == 12 && check3_2 == 1 && ran_dunji == 1)
                    || (a == 13 && check3_2 == 1 && ran_dunji == 2) || (a == 14 && check3_2 == 1 && ran_dunji == 3)
                    || (a == 8 && check3_3 == 1 && ran_sinho == 0) || (a == 15 && check3_3 == 1 && ran_sinho == 1)
                    || (a == 11 && check3_3 == 1 && ran_sinho == 2))
                {
                    Form_Moble form_moble = new Form_Moble();
                    form_moble.Show();
                    this.Visible = false;
                }
                if ((a == 6 || a == 9) && (check3_2 == 1) && (ran_dunji == 1))      //헤드셋 있을때 빌런 띄우기
                {
                    pictureBox2.Image = image_billon;   //무서운아저씨
                }
                if ((a == 6 || a == 9 || a == 11) && (check3_2 == 1) && (ran_dunji == 2))
                {
                    pictureBox2.Image = image_billon;   //사이비
                }
                if ((a == 6 || a == 9 || a == 11) && (check3_2 == 1) && (ran_dunji == 3))
                {
                    pictureBox2.Image = image_billon;   //롱패딩바바리맨
                }
                if ((a == 7 || a == 10) && (check3_3 == 1) && (ran_sinho == 1))
                {
                    pictureBox2.Image = image_billon;   //깡다구
                }
                if ((a == 7 || a == 9) && (check3_3 == 1) && (ran_sinho == 2))
                {
                    pictureBox2.Image = image_billon;   //모블학생
                }
                if (((a == 7 || a == 10) && (check3_2 == 1) && (ran_dunji == 1))
                    || ((a == 7 || a == 10 || a == 12) && (check3_2 == 1) && (ran_dunji == 2))
                    || ((a == 7 || a == 10 || a == 13) && (check3_2 == 1) && (ran_dunji == 3))
                    || ((a == 8 || a == 11) && (check3_3 == 1) && (ran_sinho == 1))
                    || ((a == 8 || a == 10) && (check3_3 == 1) && (ran_sinho == 2)))
                {
                    pictureBox2.Image = null;           //빌런 제거
                }

                if (a != 2 && check3_2 == 1)
                {
                    str.Add("(저벅...저벅...)");  //a== 5
                    if (ran_dunji == 0)    //빌런 안만남
                    {
                        str.Add("휴... 다행히 오늘은 아무도 안 만났다!!!");
                        str.Add("애들 보러 빨리 가야지");
                    }
                    else if (ran_dunji == 1) //무서운아저씨 빌런
                    {
                        str.Add("어이 거기 잠시 서봐");  //빌런 대사 a == 6
                        str.Add("(헉! 무서워 보이는 아저씨다. \n안들리는 척 해야지)"); //교수님 대사
                        str.Add("(두둠 칫!) (두둠 칫!)"); //교수님 의 몸짓
                        str.Add("에이... 칫"); //빌런 대사
                        str.Add("..."); //교수님 반응
                        str.Add("휴... 다행히 그냥 지나갔다. \n빨리 학원으로 가야지");//교수님대사
                    }
                    else if (ran_dunji == 2) //사이비 빌런
                    {
                        str.Add("저기 잠시만요...");  //빌런 대사 a == 6
                        str.Add("(큰일이다! 수상해보이는 사이비다. \n안들리는 척 해야지)"); //교수님 대사
                        str.Add("(...)"); //교수님 의 몸짓
                        str.Add("저기요~~"); //빌런 대사
                        str.Add("..."); //교수님 반응
                        str.Add("터벅...터벅..."); //빌런 지나감
                        str.Add("휴... 다행히 그냥 지나갔다. \n빨리 학원으로 가야지");//교수님대사
                    }
                    else if (ran_dunji == 3) //롱패딩바바리맨 빌런
                    {
                        str.Add("저벅...저벅...");  //빌런 걸음걸이 a == 6
                        str.Add("(저사람은 요즘에 보기 힘든 롱패딩 바바리맨?!!)"); //교수님 대사
                        str.Add("(어떡하지... 나한테 오고있어! 자연스럽게 피해가야겠다.)");//교수님 대사
                        str.Add("(멈칫)");//빌런 걸음걸이
                        str.Add("(최대한 자연스럽게 땅바닥 보고 가야지...)"); //교수님 대사
                        str.Add("(...)"); //빌런 걸음걸이
                        str.Add("(저벅...저벅...)"); //빌런 걸음걸이
                        str.Add("휴... 다행히 그냥 지나갔다. \n빨리 학원으로 가야지");//교수님대사
                    }

                }

                if (a != 2 && check3_3 == 1)  //헤드셋 있을때 신호등
                {
                    str.Add("(저벅...저벅...)");
                    str.Add("(신호 기다리는 중...)");  //a == 6
                    if (ran_sinho == 0) //빌런 안만남
                    {
                        str.Add("(신호가 초록불로 바꼇네 \n애들보러 가야지~)");
                    }
                    else if (ran_sinho == 1) //깡다구 사장
                    {
                        str.Add("(옆에서) 크흠...");  //빌런 걸음걸이 a== 7
                        str.Add("(저사람은 깡다구 사장! 뭔가 할 말이 있어보여)"); //교수님 대사
                        str.Add("(안들리는 척... 안들리는 척...)");//교수님 대사
                        str.Add("(옆에서) 에헴...");//빌런 걸음걸이
                        str.Add("(안들리는 척... 안들리는 척...)"); //교수님 대사
                        str.Add("(앗! 신호가 초록불로 바꼇다. 빨리 가야겠다.)");
                        str.Add("(타다닥!!!)");
                        str.Add("다행히 안 쫗아온다. 빨리 학원으로 가야지~");//교수님대사
                    }
                    else if (ran_sinho == 2) //모블 학생
                    {
                        str.Add("선생님 안녕하세요");  //학생 대사 a == 7
                        str.Add("(돌아보며) \n앗! 너는 아무개(전 기수)?"); //교수님 대사
                        str.Add("다음에 밥 한번 사드릴게요~");
                        str.Add("그래!");

                    }
                }
            }
            if (b_Headset == false) //헤드셋 없을때 상황   //if(Form_Inventori.Equ2.Image == null)
            {

                if (b_event_Check == true) //이벤트 클리어시 모블폼 이동
                {
                    if ((a == 8 && check3_2 == 1 && ran_dunji == 0) || (a == 14 && check3_2 == 1 && ran_dunji == 1)
                        || (a == 13 && check3_2 == 1 && ran_dunji == 2) || (a == 13 && check3_2 == 1 && ran_dunji == 3)
                        || (a == 8 && check3_3 == 1 && ran_sinho == 0) || (a == 14 && check3_3 == 1 && ran_sinho == 1)
                        || (a == 15 && check3_3 == 1 && ran_sinho == 2))
                    {
                        str.Add("...");
                        Form_Moble form_moble = new Form_Moble();
                        form_moble.Show();
                        this.Visible = false;
                    }
                }
                if (b_event_Check == false)
                {
                    if ((a == 8 && check3_2 == 1 && ran_dunji == 0) || (a == 8 && check3_3 == 1 && ran_sinho == 0))
                    {
                        str.Add("...");
                        Form_Moble form_moble = new Form_Moble();
                        form_moble.Show();
                        this.Visible = false;
                    }
                    if (a == 11 && check3_2 == 1 && ran_dunji == 1) //무서운 아저씨 이벤트
                    {
                        Form3_4_scaryman form3_4_Scaryman = new Form3_4_scaryman();
                        form3_4_Scaryman.ShowDialog();
                    }
                    if (a == 10 && check3_2 == 1 && ran_dunji == 2)
                    {
                        Form3_5_Saibi form3_5_Saibi = new Form3_5_Saibi();
                        form3_5_Saibi.ShowDialog();
                    }
                    if (a == 10 && check3_2 == 1 && ran_dunji == 3)
                    {
                        Form3_8_BabariMan form3_8_babariman = new Form3_8_BabariMan();
                        form3_8_babariman.ShowDialog();
                    }
                    if (a == 11 && check3_3 == 1 && ran_sinho == 1)
                    {
                        Form3_7_Ggangdagu form3_7_ggangdagu = new Form3_7_Ggangdagu();
                        form3_7_ggangdagu.ShowDialog();
                    }
                    if (a == 10 && check3_3 == 1 && ran_sinho == 2)
                    {
                        Form3_6_MobleStu form3_6_moblestu = new Form3_6_MobleStu();
                        form3_6_moblestu.ShowDialog();
                    }
                }

                if ((a == 6 || a == 8 || a == 10 || a == 12) && (check3_2 == 1) && (ran_dunji == 1))      //헤드셋 없을떄 빌런 띄우기
                {
                    pictureBox2.Image = image_billon;   //무서운아저씨
                }
                if ((a == 6 || a == 8 || a == 11) && (check3_2 == 1) && (ran_dunji == 2))
                {
                    pictureBox2.Image = image_billon;   //사이비
                }
                if ((a == 6 || a == 8 || a == 11) && (check3_2 == 1) && (ran_dunji == 3))
                {
                    pictureBox2.Image = image_billon;   //롱패딩바바리맨
                }
                if ((a == 7 || a == 9 || a == 11) && (check3_3 == 1) && (ran_sinho == 1))
                {
                    pictureBox2.Image = image_billon;   //깡다구
                }
                if ((a == 7 || a == 9 || a == 11 || a == 13) && (check3_3 == 1) && (ran_sinho == 2))
                {
                    pictureBox2.Image = image_billon;   //모블학생
                }
                if (((a == 7 || a == 9 || a == 11 || a == 13) && (check3_2 == 1) && (ran_dunji == 1))
                    || ((a == 7 || a == 9 || a == 12) && (check3_2 == 1) && (ran_dunji == 2))
                    || ((a == 7 || a == 9 || a == 12) && (check3_2 == 1) && (ran_dunji == 3))
                    || ((a == 8 || a == 10 || a == 12) && (check3_3 == 1) && (ran_sinho == 1))
                    || ((a == 8 || a == 10 || a == 12 || a == 14) && (check3_3 == 1) && (ran_sinho == 2)))
                {
                    pictureBox2.Image = null;           //빌런 제거
                }
                if (a != 2 && check3_2 == 1)//헤드셋 없을때 둥지식당골목길
                {
                    str.Add("(저벅...저벅...)"); //a == 5
                    if (ran_dunji == 0)    //빌런 안만남
                    {
                        str.Add("휴... 다행히 오늘은 아무도 안 만났다!!!");
                        str.Add("애들 보러 빨리 가야지");
                    }
                    else if (ran_dunji == 1) //무서운아저씨 빌런
                    {
                        str.Add("어이 거기 잠시 서봐");  //빌런 대사 a== 6
                        str.Add("(헉! 무서워 보이는 아저씨다.)"); //교수님 대사
                        str.Add("내가 절대! 퀴즈를 못푸는게 아니야!!!"); //빌런 대사
                        str.Add("(갑자기 왜 저런 말을하시지?)"); //교수님 반응
                        str.Add("안되겠다 너도 한번 풀어봐 \n다 풀면 보내줄게"); //빌런 대사
                        str.Add("...");//교수님대사
                        str.Add("이럴수가 이걸 풀다니... 크흑 \n난 바보야!!!");
                        str.Add("아침부터 무서운아저씨를 만나서 힘드네... \n애들한테 문제 풀게하고 좀 쉬어야지");
                    }
                    else if (ran_dunji == 2) //사이비 빌런
                    {
                        str.Add("저기요~ 잠시만요");  //빌런 대사 a == 6
                        str.Add("(헉! 수상한 사이비다)"); //교수님 대사
                        str.Add("우리하고 같이 가고싶지 않으면 문제를 맞춰봐 \n그러면 보내줄게"); //빌런 대사
                        str.Add("(어려운 문제면 어떻게 하지?)"); //교수님 반응
                        str.Add("...");//교수님대사
                        str.Add("이걸 맞추다니 더 마음에 들어요! 저희랑 같이가요~");
                        str.Add("뭐?! 안되겠다 도망쳐야겠다. \n(타다닥!!!)");
                    }
                    else if (ran_dunji == 3) //롱패딩바바리맨 빌런
                    {
                        str.Add("터벅...터벅...");  //빌런 걸음걸이 a == 6
                        str.Add("(요즘에 보기힘든 롱패딩바바리맨?!!)"); //교수님 대사
                        str.Add("어이~ 거기 아가씨 내 뒤로 지나가고싶으면 내가 주는 문제를 맞춰봐!!"); //빌런 대사
                        str.Add("(엥? 갑자기 무슨 상황인거야?)"); //교수님 반응
                        str.Add("...");//교수님대사
                        str.Add("이 문제를 풀다니... 약속대로 보내주지 지나가라!!! (당당!!)");
                        str.Add("진짜 이상한 사람이다. 빨리 도망가야지\n(타다닥!!!)");
                    }
                }
                if (a != 2 && check3_3 == 1) //헤드셋 없을때 신호등
                {
                    str.Add("(저벅...저벅...)");
                    str.Add("(신호 기다리는 중...)");   //a==6
                    if (ran_sinho == 0) //빌런 안만남
                    {
                        str.Add("(신호가 초록불로 됐다! 애들보러 가야지~)");
                    }
                    else if (ran_sinho == 1) //깡다구 사장
                    {
                        str.Add("(옆에서) 크흠...");  //빌런 걸음걸이 a== 7
                        str.Add("(저사람은 깡다구 사장! 뭔가 할 말이 있어보여)"); //교수님 대사
                        str.Add("내가 물어볼게 있어 이걸 맞추면 보내줄게"); //빌런 대사
                        str.Add("(아... 신호바뀌면 가야되는데)");// 교수님 대사
                        str.Add("...");//교수님 대사
                        str.Add("이럴수가 너무 고마워!! \n답례로 우리가게와 한 턱 쏠게");//빌런 대사
                        str.Add("네 알겠습니다. \n(휴... 저긴 안가야지");

                    }
                    else if (ran_sinho == 2) //모블 학생
                    {
                        str.Add("선생님 안녕하세요");  //학생 대사 a == 7
                        str.Add("(돌아보며) \n앗! 너는 아무개(전 기수)?"); //교수님 대사
                        str.Add("저 물어볼게 있습니다."); //학생 대사
                        str.Add("어떤 거야?"); //교수님 대사
                        str.Add("오 감사합니다!");
                        str.Add("너는 다시 배워야겠다. 따라올래?");
                        str.Add("아니요! 괜찬습니다. 조심히 가세요!");
                        str.Add("그래~ 잘가");
                    }
                }
            }
            if (isProcessing)
            {
                return;
            }

            if (a + 1 <= str.Count)
            {
                string text = str[a];
                a++;

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
    }
}
