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
    public partial class Form_MobleEvent : Form
    {
        public static int count = 10;
        double nTotalSeconds = 300;
        DateTime dt;

        public Form_MobleEvent()
        {
            InitializeComponent();
            dt = new DateTime();
            timer1.Start();
            timer2.Start();

        }

        private void btn_HidingHint_Click(object sender, EventArgs e)
        {
            Form_MobleHint1 form_MobleHint1 = new Form_MobleHint1();
            form_MobleHint1.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
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

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "21")
            {
                MessageBox.Show("열렸습니다!");
                Form_Moble_ComputerScreen form_Moble_ComputerScreen = new Form_Moble_ComputerScreen();
                form_Moble_ComputerScreen.Show();
                Form_Moble form_Moble = new Form_Moble();
                form_Moble.Visible = false;
                this.Close();
            }
            else
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("비밀번호를 입력해주세요!");
                    return;
                }
                if (count > 1)
                {
                    count--;
                    MessageBox.Show($"틀렸습니다. 입력 기회가 {count}회 남았습니다. ㅋ" +
                        $"\n(입력기회를 모두 소진하시면 게임 오버됩니다! ㅋ");
                    return;
                }
                else if (count == 1)
                {
                    count--;
                    MessageBox.Show("틀렸습니다. 모든 기회를 소진하셨습니다.\n잠금모드를 활성화합니다.\n" +
                        "잠금 해제하시려면 관리자에게 문의해주세요.\n010-1111-2222");
                    MessageBox.Show("Game Over");
                    Form_GameOver.gameover = "컴퓨터 앞에서 시간을 너무 써서 브로커를 만나 게임오버!! ㅋㅋ";
                    Form_GameOver form_GameOver = new Form_GameOver();
                    form_GameOver.Show();
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nTotalSeconds == 0)
            {
                timer1.Stop();
                timer2.Stop();
                
                MessageBox.Show("제한 시간 아웃!");
                Form_GameOver.gameover = "컴퓨터 앞에서 시간을 너무 써서 브로커를 만나 게임오버!! ㅋㅋ";
                MessageBox.Show("Game over");
                Form_GameOver form_GameOver = new Form_GameOver();
                form_GameOver.Show();

                timer1.Enabled = false;
                this.Close();
            }
            nTotalSeconds--;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lb_minute.Text = dt.AddSeconds(nTotalSeconds).ToString("mm:ss");

        }
    }
}
