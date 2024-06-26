using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinForms_Pang_Project
{
    public partial class Form3_1_Zzang : Form
    {
        public static decimal numeric_sum1 = 0;
        public static decimal numeric_sum2 = 0;
        public static int seatnumber = 0;
        public static string str = "";
        

        public Form3_1_Zzang()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 1000;
            DateTime today = DateTime.Now;
            label1.Text = today.ToString("MM/dd");
            label2.Text = today.AddDays(1).ToString("MM/dd");
            label3.Text = today.AddDays(2).ToString("MM/dd");
            label4.Text = today.AddDays(3).ToString("MM/dd");
            label5.Text = today.AddDays(4).ToString("MM/dd");
            label6.Text = today.AddDays(5).ToString("MM/dd");
            label7.Text = today.AddDays(6).ToString("MM/dd");
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Visible = true;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int bt1 = int.Parse(button1.Text.Replace(":", ""));
            int bt2 = int.Parse(button2.Text.Replace(":", ""));
            int bt3 = int.Parse(button3.Text.Replace(":", ""));
            int bt4 = int.Parse(button4.Text.Replace(":", ""));
            int bt5 = int.Parse(button5.Text.Replace(":", ""));
            int bt6 = int.Parse(button6.Text.Replace(":", ""));
            int bt7 = int.Parse(button7.Text.Replace(":", ""));
            int bt8 = int.Parse(button8.Text.Replace(":", ""));
            if (bt1 <= int.Parse(today.ToString("HHmm")))
                button1.Enabled = false;
            if (bt2 <= int.Parse(today.ToString("HHmm")))
                button2.Enabled = false;
            if (bt3 <= int.Parse(today.ToString("HHmm")))
                button3.Enabled = false;
            if (bt4 <= int.Parse(today.ToString("HHmm")))
                button4.Enabled = false;
            if (bt5 <= int.Parse(today.ToString("HHmm")))
                button5.Enabled = false;
            if (bt6 <= int.Parse(today.ToString("HHmm")))
                button6.Enabled = false;
            if (bt7 <= int.Parse(today.ToString("HHmm")))
                button7.Enabled = false;
            if (bt8 <= int.Parse(today.ToString("HHmm")))
                button8.Enabled = false;

            if (label1.BackColor != Color.Firebrick)
            {
                label1.BackColor = Color.Firebrick;
                label2.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                labelChoice.Text = label1.Text;
            }
            else
            {
                label1.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.BackColor != Color.Firebrick)
            {
                label2.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label2.Text;
            }
            else
            {
                label2.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.BackColor != Color.Firebrick)
            {
                label3.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label2.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label3.Text;
            }
            else
            {
                label3.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            if (label4.BackColor != Color.Firebrick)
            {
                label4.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label2.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label4.Text;
            }
            else
            {
                label4.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.BackColor != Color.Firebrick)
            {
                label5.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label2.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label5.Text;
            }
            else
            {
                label5.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.BackColor != Color.Firebrick)
            {
                label6.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label2.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label7.BackColor = Color.LightGray;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label6.Text;
            }
            else
            {
                label6.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.BackColor != Color.Firebrick)
            {
                label7.BackColor = Color.Firebrick;
                label1.BackColor = Color.LightGray;
                label2.BackColor = Color.LightGray;
                label3.BackColor = Color.LightGray;
                label4.BackColor = Color.LightGray;
                label5.BackColor = Color.LightGray;
                label6.BackColor = Color.LightGray;

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;

                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;

                labelChoice.Text = label7.Text;
            }
            else
            {
                label7.BackColor = Color.LightGray;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;

                labelChoice.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            labelChoice.Text += " / " + button8.Text;
        }
        /******************** **************************/

        private void btnReChoice_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            labelChoice.Text = "";
            label1.BackColor = Color.LightGray;
            label2.BackColor = Color.LightGray;
            label3.BackColor = Color.LightGray;
            label4.BackColor = Color.LightGray;
            label5.BackColor = Color.LightGray;
            label6.BackColor = Color.LightGray;
            label7.BackColor = Color.LightGray;

            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            btnA1.BackColor = Color.Transparent;
            btnA2.BackColor = Color.Transparent;
            btnA3.BackColor = Color.Transparent;
            btnA4.BackColor = Color.Transparent;
            btnA5.BackColor = Color.Transparent;
            btnA6.BackColor = Color.Transparent;
            btnB1.BackColor = Color.Transparent;
            btnB2.BackColor = Color.Transparent;
            btnB3.BackColor = Color.Transparent;
            btnB4.BackColor = Color.Transparent;
            btnB5.BackColor = Color.Transparent;
            btnB6.BackColor = Color.Transparent;
            btnC1.BackColor = Color.Transparent;
            btnC2.BackColor = Color.Transparent;
            btnC3.BackColor = Color.Transparent;
            btnC4.BackColor = Color.Transparent;
            btnC5.BackColor = Color.Transparent;
            btnC6.BackColor = Color.Transparent;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numeric_sum1 = numericUpDown1.Value * 15000;
            labelPrice.Text = (numeric_sum1 + numeric_sum2).ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numeric_sum2 = numericUpDown2.Value * 8000;
            labelPrice.Text = (numeric_sum1 + numeric_sum2).ToString();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            if (btnA1.BackColor == Color.Transparent)
            {
                btnA1.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A1";
            }
            else if (btnA1.BackColor == Color.Orange)
            {
                btnA1.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if (btnA2.BackColor == Color.Transparent)
            {
                btnA2.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A2";
            }
            else if (btnA2.BackColor == Color.Orange)
            {
                btnA2.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if (btnA3.BackColor == Color.Transparent)
            {
                btnA3.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A3";
            } 
            else if (btnA3.BackColor == Color.Orange)
            {
                btnA3.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if (btnA4.BackColor == Color.Transparent)
            {
                btnA4.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A4";
            }
            else if (btnA4.BackColor == Color.Orange)
            {
                btnA4.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if (btnA5.BackColor == Color.Transparent)
            {
                btnA5.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A5";
            }
            else if (btnA5.BackColor == Color.Orange)
            {
                btnA5.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if (btnA6.BackColor == Color.Transparent)
            {
                btnA6.BackColor = Color.Orange;
                seatnumber += 1;
                str += " A6";
            }
            else if (btnA6.BackColor == Color.Orange)
            {
                btnA6.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if (btnB1.BackColor == Color.Transparent)
            {
                btnB1.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B1";
            }
            else if (btnB1.BackColor == Color.Orange)
            {
                btnB1.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if (btnB2.BackColor == Color.Transparent)
            {
                btnB2.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B2";
            }
            else if (btnB2.BackColor == Color.Orange)
            {
                btnB2.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if (btnB3.BackColor == Color.Transparent)
            {
                btnB3.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B3";
            }
            else if (btnB3.BackColor == Color.Orange)
            {
                btnB3.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if (btnB4.BackColor == Color.Transparent)
            {
                btnB4.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B4";
            }
            else if (btnB4.BackColor == Color.Orange)
            {
                btnB4.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if (btnB5.BackColor == Color.Transparent)
            {
                btnB5.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B5";
            }
            else if (btnB5.BackColor == Color.Orange)
            {
                btnB5.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if (btnB6.BackColor == Color.Transparent)
            {
                btnB6.BackColor = Color.Orange;
                seatnumber += 1;
                str += " B6";
            }
            else if (btnB6.BackColor == Color.Orange)
            {
                btnB6.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            if (btnC1.BackColor == Color.Transparent)
            {
                btnC1.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C1";
            }
            else if (btnC1.BackColor == Color.Orange)
            {
                btnC1.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            if (btnC2.BackColor == Color.Transparent)
            {
                btnC2.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C2";
            }
            else if (btnC2.BackColor == Color.Orange)
            {
                btnC2.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            if (btnC3.BackColor == Color.Transparent)
            {
                btnC3.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C3";
            }
            else if (btnC3.BackColor == Color.Orange)
            {
                btnC3.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            if (btnC4.BackColor == Color.Transparent)
            {
                btnC4.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C4";
            }
            else if (btnC4.BackColor == Color.Orange)
            {
                btnC4.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            if (btnC5.BackColor == Color.Transparent)
            {
                btnC5.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C5";
            }
            else if (btnC5.BackColor == Color.Orange)
            {
                btnC5.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            if (btnC6.BackColor == Color.Transparent)
            {
                btnC6.BackColor = Color.Orange;
                seatnumber += 1;
                str += " C6";
            }
            else if (btnC6.BackColor == Color.Orange)
            {
                btnC6.BackColor = Color.Transparent;
                seatnumber -= 1;
                str = str.Substring(0, str.Length - 3);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (seatnumber != (numericUpDown1.Value + numericUpDown2.Value))
                MessageBox.Show("인원 수와 좌석 개수가 일치하는지 확인해 주십시오.");
            else
            {
                MessageBox.Show($"인원 수: {seatnumber}명\n" +
                    $"결제 금액: {labelPrice.Text}원 \n좌석 번호:{str}\n결제를 진행합니다.");
                Form3_1_Zzang_Pay form3_1_ZP = new Form3_1_Zzang_Pay();
                form3_1_ZP.Show();
            }
        }
    }
}
