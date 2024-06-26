using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Xml.Linq;
using Group5_TeamProject;
using _3_1;
using System.Media;
using WMPLib;


namespace TeamProject_part2
{
    public partial class Step2 : Form
    {
        static public List<string> commu2 = new List<string>(); // TextBox 대화 리스트
        public static bool gameover_check = false;
        public static int gameover = 0;
        public static string gameover_choice = ""; // 실패시 텍스트 넘겨주기
        static int b = 0;
        static int cheaked_choice1 = 0;
        static int cheaked_choice2 = 0;
        static int choice_chat = 0;
        private bool isProcessing = false;

        public Step2()
        {
            InitializeComponent();

            this.BackgroundImage = start_image;
            panel1.BringToFront();
            label1.BringToFront();

            /*  0 */
            commu2.Add("[주옥이는 집에서 나와 밖을 둘러보았다.]");
            /*  1 */
            commu2.Add("오늘은 지하철까지 어떻게 갈까?");
            /*  2 */
            commu2.Add("[주옥이는 오늘 기분이 좋아서 걸어서 가기로 마음먹었다.]");
            /*  3 */
            commu2.Add("오늘 날씨가 정말 좋아");
            /*  4 */
            commu2.Add("[그렇게 기분좋게 지하철까지 걸어가던 도중에...]");
            /*  5 */
            commu2.Add("[구두의 굽이 부러져버렸다!!!]");
            /*  6 */
            commu2.Add("아이고 아이고, 구두가 또 뿌러지다니");
            /*  7 */
            commu2.Add("집으로 가서 운동화로 갈아신어야겠네..");
            /*  8 */
            commu2.Add("[집에 돌아갔는데 현관문 비번이 바뀌어있었다?]");
            /*  9 */
            commu2.Add("[의미없는 시간소모를 하고 결국 지하철역에 도착했다.]");
            /* 10 */
            commu2.Add("");
            /* 11 */
            commu2.Add("[오늘은 걷기가 힘들어서 버스를 타기로 마음먹었다.]");
            /* 12 */
            commu2.Add("역시 걷는것보단 버스가 편하지");
            /* 13 */
            commu2.Add("[그렇게 버스계단을 올라 개찰구에서 리더기앞에 지갑을 댔다.]");
            /* 14 */
            commu2.Add("");
            /* 15 */
            commu2.Add("");
            /* 16 */
            commu2.Add("[늘 타던 지하철에 탔다.]");
            /* 17 */
            commu2.Add("'오늘은 신기한 사람들이 많네'");
            /* 18 */
            commu2.Add("'어! 내가 오늘 헤드셋을 가져왔던가???'");
            /* 19 */
            commu2.Add("헤드셋 판별 대사 자리");
            /* 20 */
            commu2.Add("빌런 출몰 시스템 자리");
            /* 21 */
            commu2.Add("빌런 대사 1");
            /* 22 */
            commu2.Add("빌런 대사 2");
            /* 23 */
            commu2.Add("빌런 대사 3");
            /* 24 */
            commu2.Add("[퀴즈를 맞추니 이상한 사람이 춤을추며 사라졌다.]");
            /* 25 */
            commu2.Add("이상한 사람이네");
            /* 26 */
            commu2.Add("[주옥이는 지하철에서 내려 지하철역 위로 올라왔다.]");
            /* 27 */
            commu2.Add("챕터2의 기분");
        }

        Random rand = new Random();

        Bitmap bit1 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\자르반84세.jpg");
        Bitmap bit2 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\아수라.jpg");
        Bitmap bit3 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\pixel_art_road.png");
        Bitmap start_image = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\배경.jpg");
        Bitmap bit4 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\지하철 내부.jpg");
        Bitmap bit5 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\in bus.jpg");
        Bitmap jarban84 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\자르반84세읭읭이.jpg");
        Bitmap Manman = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\이상한_아저씨_읭읭이.png");
        Bitmap Txt = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\textbox_design.png");
        Bitmap bus_check = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\bus_check.jpg");
        Bitmap Dance = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\Danse.gif");
        public static Bitmap jarban84_2 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\자르반84세읭읭이 2.jpg");
        public static Bitmap jarban84_3 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\자르반84세읭읭이ver.2.jpg");
        public static Bitmap Manman_2 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\이상한_아저씨_읭읭이2.png");
        public static Bitmap Manman_3 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\이상한_아저씨_읭읭이ver.2.png");

        Button button_s1 = new Button(); Button button_s2 = new Button();


        // WindowsMediaPlayer sound = new WindowsMediaPlayer();


        private async Task ProcessText(string text)
        {
            label1.Text = "";
            label2.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += text[i].ToString();
                await Task.Delay(10);
            }
        }

        private async Task ProcessText2(string text)
        {
            label1.Text = "";
            label2.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                label2.Text += text[i].ToString();
                await Task.Delay(10);
            }
        }


        public void First_button()
        {
            button_s1.Size = new System.Drawing.Size(120, 50); button_s1.Location = new Point(600, 739);
            button_s1.Text = "걸어서 간다"; button_s1.Font = new Font("Comic Ms", 15, FontStyle.Italic);
            button_s1.Image = Txt;

            button_s1.Click += new EventHandler(button_s1_Click);
            this.Controls.Add(button_s1);

            button_s1.BringToFront();

            void button_s1_Click(Object sender, EventArgs e)
            {

                DialogResult result = MessageBox.Show($"귀찮은데도 걸어서 가는게 맞을까?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    button_s1.Dispose(); button_s2.Dispose();
                    claer_all();
                    this.BackgroundImage = bit3;

                    cheaked_choice1 = 1;
                }
                else if (result == DialogResult.No) { MessageBox.Show("다시 골라보자."); }
            }

            button_s2.Size = new System.Drawing.Size(150, 50); button_s2.Location = new Point(750, 739);
            button_s2.Text = "버스를 타고 간다"; button_s2.Font = new Font("Comic Ms", 15, FontStyle.Italic);
            button_s2.Image = Txt;

            button_s2.Click += new EventHandler(button_s2_Click);
            this.Controls.Add(button_s2);

            button_s2.BringToFront();

            void button_s2_Click(Object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show($"이렇게 좋은날에 정말로 버스를 타고 갈까?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    button_s1.Dispose(); button_s2.Dispose();
                    claer_all();
                    this.BackgroundImage = bit5;

                    cheaked_choice1 = 2;
                }
                else if (result == DialogResult.No) { MessageBox.Show("다시 골라보자."); }
            }
        }

        public void Two_button()    // 현관문으로 돌아가는 이벤트
        {
            Step2_3 form = new Step2_3();  // 현관문 폼 출력
            form.Show();
        }

        public void Tri_button()
        {
            Step2_1 form2 = new Step2_1();
            form2.Show();
        }

        public void Tri_button2()
        {
            Step2_2 form3 = new Step2_2();
            form3.Show();
        }

        void claer_all()
        {
            pictureBox2.Image = null;
            pictureBox4.Image = null;

            pictureBox2.SendToBack();
            pictureBox4.SendToBack();

            pictureBox5.BringToFront();
            panel1.BringToFront();
            label1.BringToFront();
        }

        void show_bilun()
        {
            pictureBox2.BringToFront();
            pictureBox4.BringToFront();
            panel1.BringToFront();
            label1.BringToFront();
        }

        private async void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isProcessing) { return; }

            if (gameover_check) 
            { 
                Form_GameOver go = new Form_GameOver(); 
                go.Show();  this.Hide();
            }

            if (b == 28)
            {
                Form3_1 form3_1 = new Form3_1();
                form3_1.Show();
                this.Hide();
            }

            if (b == 2)
            {
                First_button();

                if (cheaked_choice1 == 0) { return; }
                else if (cheaked_choice1 == 1) { b = 2; }
                else if (cheaked_choice1 == 2) { b = 11; }
            }

            
            if (b == 9) { Two_button(); }
            if (b == 10) { b = 16; }
            if (b == 12)
            {
                if (Form_MainStory_Home.Inventory.Contains("카드") == true)
                {
                    commu2[b + 1] = "(삑! 성인입니다.)";
                    commu2[b + 2] = "버스 좌석에 앉아 바깥풍경을 보며 지하철역에 도착했다.";
                }
                else if (Form_MainStory_Home.Inventory.Contains("카드") == false)
                {
                    commu2[b + 1] = "........";
                    commu2[b + 2] = "카드를 두고와 버렸어!\r\n집으로 돌아가서 카드를 가져와야겠어";
                }
            }

            if (b == 13) { pictureBox2.Image = bus_check; }

            if (b == 15) 
            { 
                claer_all(); 

                if (commu2[b -1] == "카드를 두고와 버렸어!\r\n집으로 돌아가서 카드를 가져와야겠어")
                { Two_button(); commu2[b] = "[의미없는 시간소모를 하고 결국 지하철역에 도착했다.]"; }
            }

            if (b == 15 || b == 16) { this.BackgroundImage = bit4; }

            if (b == 19)
            {
                if (Form_MainStory_Home.Inventory.Contains("헤드셋") == true)   // 이후 리스트 변경 (정수형 0, 1 판단)
                {
                    cheaked_choice2 = 0;
                    commu2[b] = "다행이야 가져왔네";
                    commu2[b + 1] = "[아무일도 없이 지하철은 천안역에 도착했다.]";
                    commu2[27] = "오늘은 아무일도 없어서 다행이야";
                }
                else if (Form_MainStory_Home.Inventory.Contains("헤드셋") == false)
                {
                    if (rand.Next(0, 3) == 1)
                    {
                        cheaked_choice2 = 2;
                        commu2[b] = "어라 두고와버렸어";
                        commu2[b + 1] = "[{System} : (이상한) 아저씨가 등장했다!]";
                        commu2[b + 2] = "뭐";
                        commu2[b + 3] = "왜";
                        commu2[b + 4] = "뭐";
                    }
                    else
                    {
                        cheaked_choice2 = 1;
                        commu2[b] = "어라 두고와버렸어";
                        commu2[b + 1] = "[{System} : 자르반 84세가 등장했다!]";
                        commu2[b + 2] = "내가 해병대 1긴데.....";
                        commu2[b + 3] = ".......";
                        commu2[b + 4] = "지금당장 내 퀴즈를 풀지 않으면\r\n데마시아의 힘으로 널 심판하겠다.";

                    }
                    commu2[27] = "벌써부터 하루가 힘드네";
                }
            }

            if (b == 20)
            {
                pictureBox2.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
            }

            if ( b == 21)
            {
                if (cheaked_choice2 == 1)
                {
                    // sound.URL = @"C:\C#\WinForm_TeamProject_Group5\project2_image\해병대.mp3";
                    // choice_chat = 1; 
                    pictureBox2.Image = bit1;
                    pictureBox4.Image = jarban84;
                }
                else if (cheaked_choice2 == 2)
                {
                    // sound.URL = @"C:\C#\WinForm_TeamProject_Group5\project2_image\야.mp3";
                    // choice_chat = 1; 
                    pictureBox2.Image = bit2;
                    pictureBox4.Image = Manman;
                }
            }

            // if ( b == 22) { sound.controls.play(); }
            // if ( b == 23) { sound.controls.stop(); }

            if (b == 21 && cheaked_choice2 == 0) { b = 26; }
            if (b == 21 && cheaked_choice2 != 0) { pictureBox2.Image = null; }
            else if (b == 24 && cheaked_choice2 == 1) { Tri_button(); }
            else if (b == 24 && cheaked_choice2 == 2) { Tri_button2(); }

            if (b == 24) {  claer_all(); choice_chat = 0; pictureBox2.Image = Dance; }
            if (b == 25) { pictureBox5.Image = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\Professor after-remove.png"); }
            if (b == 26) {  claer_all(); }


    

            if (b < commu2.Count && choice_chat == 0)
            {
                string text = commu2[b];
                b++;


                isProcessing = true;
                await ProcessText(text);
                isProcessing = false;
            }


            /*else if (b < commu2.Count && choice_chat == 1)
            {
                string text = commu2[b];
                b++;

                isProcessing = true;
                await ProcessText2(text);
                isProcessing = false;
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameover == 1) 
            { 
                pictureBox2.Image = null; b++; 
                label1.Text = "데마시아를 당해버렸다...";
                gameover_choice = "데마시아를 당해버렸다...";
            }
            if (gameover == 2) 
            { 
                pictureBox2.Image = null; b++; 
                label1.Text = "(이상한) 아저씨의 그림교실에 끌려가버렸다...";
                gameover_choice = "(이상한) 아저씨의 그림교실에 끌려가버렸다...";
            }
        }

        private void Step2_Load(object sender, EventArgs e)
        {
            
        }

        private async void Form1_MouseUp(object sender, MouseEventArgs e)
        {   // 변경전 이벤트
            //if (e.X >= 32 && e.X <= 1152 && e.Y >= 592 && e.Y <= 795)
            //{
            //    if (event_count == 0)
            //    {
            //        if (count1 + 1 <= start.Length)
            //        {
            //            label1.Text = "";
            //            string text = start[count1];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count1++;

            //            if (count1 == 2)
            //            {
            //                First_button();
            //                count1 = 0;
            //            }
            //        }
            //    }

            //    if (event_count == 1)
            //    {
            //        if (count1 + 1 <= GO_Foot.Length)
            //        {
            //            label1.Text = "";
            //            string text = GO_Foot[count1];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count1++;

            //            if (count1 == 6)
            //            {
            //                Two_button();
            //            }
            //        }
            //    }

            //    else if (event_count == 2)
            //    {
            //        claer_all();

            //        if (count1 + 1 <= GO_Bus.Length)
            //        {
            //            label1.Text = "";
            //            string text = GO_Bus[count1];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count1++;

            //            if (count1 == 2)
            //            {
            //                if (Bag[0] == "카드") { GO_Bus[3] = "[삐빅] 결제소리가 들리고 나는 자리에 앉았다."; GO_Bus[4] = "1"; }
            //                else { GO_Bus[3] = "아 내가 카드를 집에다 두고왔구나..."; GO_Bus[4] = "2"; }
            //            }

            //            if (GO_Bus[count1] == "1") { event_count = 3; } // 카드를 들고와서 지하철로 넘어감
            //            else if (GO_Bus[count1] == "2") { Two_button(); }   // 카드를 들고오지 않았으므로 현관문으로 복귀
            //        }
            //    }

            //    else if (event_count == 3)
            //    {
            //        claer_all();

            //        if (count2 + 1 <= In_train.Length)
            //        {
            //            label1.Text = "";
            //            string text = In_train[count2];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count2++;

            //            if (count2 == 2)
            //            {
            //                if (Bag[1] == "헤드셋") { In_train[3] = "챙겨왔구나, 헤드셋으로 노래나 듣자"; In_train[4] = "1"; }
            //                else { In_train[3] = "헤드셋을 두고왔네.."; In_train[4] = "2"; }
            //            }

            //            if (In_train[count2] == "1") { event_count = 4; }   // 헤드셋을 가져왔으므로 그냥 넘어감
            //            else if (In_train[count2] == "2")   // 헤드셋을 가져오지 않았으므로 빌런 등장
            //            {
            //                if (rand.Next(0, 2) == 1)
            //                {
            //                    event_count = 5;
            //                }
            //                else
            //                {
            //                    event_count = 6;
            //                }
            //            }
            //        }
            //    }

            //    else if (event_count == 5)
            //    {
            //        claer_all();

            //        pictureBox2.Image = bit1;
            //        pictureBox2.BringToFront();
            //        label1.Text = "";

            //        if (count3 + 1 <= jarban_hal.Length)
            //        {
            //            label1.Text = "";
            //            string text = jarban_hal[count3];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count3++;

            //            if (count3 == 3)
            //            {
            //                Form2 form2 = new Form2();
            //                form2.Show();

            //                event_count = 7;
            //            }
            //        }
            //    }

            //    else if (event_count == 6)
            //    {
            //        claer_all();

            //        pictureBox2.Image = bit2;
            //        pictureBox2.BringToFront();
            //        label1.Text = "";

            //        if (count3 + 1 <= WhatMan.Length)
            //        {
            //            label1.Text = "";
            //            string text = WhatMan[count3];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count3++;

            //            if (count3 == 3)
            //            {
            //                Form3 form3 = new Form3();
            //                form3.Show();

            //                event_count = 7;
            //            }
            //        }
            //    }

            //    else if (event_count == 7)
            //    {
            //        claer_all();

            //        if (count4 + 1 <= End.Length)
            //        {
            //            label1.Text = "";
            //            string text = End[count4];
            //            await DisplayTextWithDelay(text, label1, 10);
            //            count4++;
            //        }
            //    }
            //}
        }
    }
}
