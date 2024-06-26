using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject_part2
{
    public partial class Step2_2 : Form
    {
        public Step2_2()
        {
            InitializeComponent();
            pictureBox2.BackgroundImage = Step2.Manman_2;
        }

        Bitmap bit = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project2_image\아재퀴즈.png");
        int count = 0;

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "해산물")
                {
                    this.Close();
                }
                else
                {
                    textBox1.Text = "젊은 사람이 이것도 못맞추나";
                }
            }
            else
            {
                if (textBox1.Text.Length > 3)
                {
                    textBox1.Text = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count = count + 1;

            if (count == 5)  { label1.Text += "\r\n그림의 요소는 3개며 각각 한글자로 더해진다."; }
            if (count == 10) { label1.Text += "\r\n위 그림에는 해와 산, 그리고 바다가 있지"; }
            if (count == 15) { label1.Text += "\r\n바다는 뭐로 이루어져있지?"; }
            if (count == 20) { label1.Text = "멍첨한놈 아직도 못맞췄나"; }

            if (count == 30)
            {
                label1.Text = "";
                pictureBox1.Dispose(); pictureBox2.Dispose(); textBox1.Dispose();
                this.BackgroundImage = Step2.Manman_3;
            }

            if (count == 31) { label2.Text += "멍"; }
            if (count == 32) { label2.Text += "  청"; }
            if (count == 33) { label2.Text += "  한"; }
            if (count == 34) { label2.Text += "  놈"; }
            if (count == 35) { Step2.gameover_check = true; Step2.gameover = 2; this.Close(); }

        }

        private void Step2_2_Load(object sender, EventArgs e)
        {
            label1.Text = "위 그림을 보고 연상되는 답을 써봐 (3글자)";
            pictureBox1.Image = bit;
        }
    }
}
