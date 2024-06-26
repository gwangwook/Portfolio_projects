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

namespace TeamProject_part2
{
    public partial class Step2_1 : Form
    {
        WindowsMediaPlayer sound = new WindowsMediaPlayer();
        int count = 0;

        public Step2_1()
        {
            InitializeComponent();

            pictureBox1.BackgroundImage = Step2.jarban84_2;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "주옥") { Step2.gameover_check = false; this.Close(); }
                else { textBox1.Text = "젊은 사람이 이것도 못맞추나"; }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count + 1;

            if (count == 30) { textBox1.Text = "젊은 사람이 이것도 못풀어?"; }

            if (count == 40) 
            { 
                label1.Text = ""; 
                textBox1.Dispose(); 
                pictureBox1.Dispose();   
                this.BackgroundImage = Step2.jarban84_3;
                label2.Text = "데";
            }
            if (count == 41) { label2.Text += "   마"; }
            if (count == 42) { label2.Text += "   시"; }
            if (count == 43) 
            { 
                label2.Text += "   아";
                sound.URL = @"C:\C#\WinForm_TeamProject_Group5\project2_image\데마시아.mp3";
                sound.controls.play(); 
            }

            if (count == 45) 
            { 
                sound.controls.stop();
                Step2.gameover_check = true; 
                Step2.gameover = 1; 
                this.Close(); 
            }
        }

        private void Step2_1_Load(object sender, EventArgs e)
        {
            label1.Text = "내 조카 주옥이의 아버지는 5명의 자식이있어\r\n그 딸들의 이름은 지연, 윤수, 종현, 영진이야\r\n그럼 마지막 자식의 이름은 무엇일까?";
        }
    }
}
