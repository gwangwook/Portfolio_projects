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

namespace _3_1
{
    public partial class Form3_6_MobleStu : Form
    {
        double nTotalSeconds = 300;
        DateTime dt;
        int count = 5;
        public Form3_6_MobleStu()
        {
            InitializeComponent();
            dt = new DateTime();
            timer1.Start();
            timer2.Start();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tb_answer.Text == "클래스" || tb_answer.Text == "Class" || tb_answer.Text == "class")
                {
                    MessageBox.Show("정답");
                    Form3_1.b_event_Check = true;
                    this.Close();
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        tb_answer.Text = "";
                        MessageBox.Show($"오답!!! \n기회가 {count}번 남았습니다! ㅋㅋ");
                    }
                    else if (count == 0)
                    {
                        Form_GameOver.gameover = "아무개한테 붙잡혀서 1000개의 질문을 다 받아줬다...";
                        MessageBox.Show("오답!!! \n모든 기회를 소진하셨습니다! ㅋㅋ");
                        MessageBox.Show("Game over");
                        Form_GameOver form_GameOver = new Form_GameOver();
                        form_GameOver.Show();
                        this.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("엥? 포기 할 수 없어");
        }

        private void timer1_Tick(object sender, EventArgs e)        //시간 담당
        {

            if (nTotalSeconds == 0)
            {
                timer1.Stop();
                timer2.Stop();
                this.Close();
                Form_GameOver.gameover = "아무개한테 붙잡혀서 1000개의 질문을 다 받아줬다...";
                MessageBox.Show("제한시간초과!! \n다음에 다시 도전해주세요 ㅋㅋ");
                MessageBox.Show("Game over");
                Form_GameOver form_GameOver = new Form_GameOver();
                form_GameOver.Show();

                timer1.Enabled = false;
            }
            nTotalSeconds--;

        }

        private void timer2_Tick(object sender, EventArgs e)        //디스플레이 담당 이유: 틱당 딜레이 최소화시켜 정확한 시간을 위해
        {
            lb_minute.Text = dt.AddSeconds(nTotalSeconds).ToString("mm:ss");

        }
    }
}
