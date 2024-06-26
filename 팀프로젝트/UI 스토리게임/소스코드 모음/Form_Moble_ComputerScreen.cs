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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Winform_TeamProject
{
    public partial class Form_Moble_ComputerScreen : Form
    {
        public static bool success_computer_event2 = false;
        public Form_Moble_ComputerScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잘못 누르셨습니다!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Form_MainStory_Home.Inventory.Contains("USB") == true)
            {
                MessageBox.Show("파일을 USB에 복사합니다!");
                progressBar1.Visible = true;
                timer1.Interval = 30;
                timer1.Start();
            }
            else
            {
                MessageBox.Show("앗! 파일을 복사할 USB를 챙겨오지 않았다!");
                MessageBox.Show("Game Over");
                Form_GameOver.gameover = "컴퓨터 앞에서 시간을 너무 써서 브로커를 만나 게임오버!! ㅋㅋ";
                Form_GameOver form_GameOver = new Form_GameOver();
                form_GameOver.Show();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("잘못 누르셨습니다!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("컴퓨터를 종료하시겠습니까?\n(컴퓨터를 종료하면 게임 오버됩니다! ㅋ)",
                "진짜 꺼?", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                MessageBox.Show("시스템 종료");
                MessageBox.Show("Game Over.");
                Form_GameOver.gameover = "컴퓨터 앞에서 시간을 너무 써서 브로커를 만나 게임오버!! ㅋㅋ";
                Form_GameOver form_GameOver = new Form_GameOver();
                form_GameOver.Show();
                this.Close();
            }
            else return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                success_computer_event2 = true;
                MessageBox.Show("복사가 완료되었습니다!");
                this.Close();
            }
        }
    }
}
