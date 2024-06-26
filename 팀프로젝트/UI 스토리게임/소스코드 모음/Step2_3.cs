using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace TeamProject_part2
{
    public partial class Step2_3 : Form
    {
        Bitmap mun2 = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\문문.png");
        Bitmap msg = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\Mail.jpg");
        Bitmap msg_in = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\message-1.png");

        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        private bool isProcessing = false;

        static public List<string> commu3 = new List<string>(); // TextBox 대화 리스트

        string a = "";
        int count = 0;
        int count_pic = 0;

        public Step2_3()
        {
            InitializeComponent();
            this.BackgroundImage = mun2;

            label2.Text = "[현관문 비밀번호가 바뀌었어...]";

            commu3.Add("'현관문 비밀번호가 뭐지???'");
            commu3.Add("그렇게 고민을 하고있을때 갑자기");
            commu3.Add("{System} : [공주님]에게서 문자메세지가 도착하였습니다.");
            commu3.Add("엄마 내가 비밀번호를 바꾸고 깜박 잊어서 말을 못해줬어");
            commu3.Add("첫번째 숫자는 C# 예비보고서의 체출월이고");
            commu3.Add("두번째와 세번째 숫자는 모블 주소의 끝자리 2자리야");
            commu3.Add("그리고 마지막은 한국사람들이 가장 좋아하는 행운의 숫자야");
            commu3.Add("비밀번호는 이렇게 네자리로 바꿨어");
            commu3.Add("그럼 열심히 맞춰줘");
        }

        private async Task ProcessText(string text)
        {
            label2.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                label2.Text += text[i].ToString();
                await Task.Delay(10);
            }
        }



        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
        }

        public void shut()
        {
            if (textBox1.Text == "비밀번호를 입력하시오")
            {
                textBox1.Text = "";
            }
            if (textBox1.TextLength < 4)
            {
                textBox1.Text += a;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "1"; shut(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "2"; shut(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "3"; shut(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "4"; shut(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "5"; shut(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "6"; shut(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "7"; shut(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "8"; shut(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "9"; shut(); }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (count_pic == 1) { a = "0"; shut(); }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            shut();

            if (textBox1.TextLength < 5)
                textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1557")
            {
                MessageBox.Show("정답입니다.");
                this.Close();
            }
            else
            {
                MessageBox.Show("틀렸습니다.");
                textBox1.Text = "비밀번호를 입력하시오";
            }
        }

        

        private async void Text_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (isProcessing) { return; }

            if (count == 3)
            {
                pictureBox1.Image = msg;
                panel1.BackgroundImage = msg_in;
                // sound.URL = @"C:\C#\WinForm_TeamProject_Group5\project2_image\딸1.mp3";
                // sound.controls.play();
            }
            if (count == 4)
            {
                // sound.controls.stop();
            }
            if (count == 5)
            {
                label1.Text = "C# 예비보고서 제출날 [ ]월 30일\r\n";
            }
            if (count == 6)
            {
                label1.Text += "\r\n모블 주소 : 천안시 동남구 대흥로 2[ ][ ]\r\n";
                // sound.controls.stop();
                // sound.controls.play();
            }
            if (count == 7)
            {
                label1.Text += "\r\n행운의 숫자 : [ ]";
                // sound.controls.stop();
                // sound.controls.play();
            }

            if (count == 8) { count_pic = 1; }

            if (count < commu3.Count )
            {
                string text = commu3[count];
                count++;


                isProcessing = true;
                await ProcessText(text);
                isProcessing = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Step2_3_Load(object sender, EventArgs e)
        {

        }

        
    }
}
