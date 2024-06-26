using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Pang_Project
{
    public partial class Form3_1_Zzang_Pay : Form
    {
        int enter1 = 0;
        public Form3_1_Zzang_Pay()
        {
            InitializeComponent();
            label3.Text = Form3_1_Zzang.seatnumber.ToString();
            label4.Text = (Form3_1_Zzang.numeric_sum1 + Form3_1_Zzang.numeric_sum2).ToString();
        }

        private void radioAgree_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgree.Checked)
            {
                label8.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label8.Visible = false;
                textBox1.Visible = false;
            }
        }

        private void btnEnter1_Click(object sender, EventArgs e)
        {
            if (radioAgree.Checked)
            {
                if (textBox1.Text != "")
                {
                    MessageBox.Show("적립되었습니다!");
                    enter1 = 1;
                }
                else
                {
                    MessageBox.Show("회원번호를 입력해주세요!");
                }
            }
            else if (radioDisagree.Checked)
            {
                MessageBox.Show("적립안함을 선택하셨습니다!");
                enter1 = 1;
            }
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();
            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("L.Pay(엘페이)");
                lbPayInfo.Items.Add("PAYCO(페이코)");
                lbPayInfo.Items.Add("Kakao Pay(카카오페이)");
                lbPayInfo.Items.Add("Toss(토스페이)");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("신용카드");
                lbPayInfo.Items.Add("체크카드");
                lbPayInfo.Items.Add("삼성페이");
                lbPayInfo.Items.Add("애플페이");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (enter1 == 1)
            {
                if (cbPay.Text == "" || lbPayInfo.Text == "")
                {
                    MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요.");
                    return;
                }
                string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + "결제방법을" + "\n선택하셨습니다.";
                MessageBox.Show(str);
                MessageBox.Show("결제가 완료되었습니다.");
                //Form3_1_Zzang form3_1_zzang = new Form3_1_Zzang();
                //form3_1_zzang.Close();
                //Form1 form1 = new Form1();
                //form1.Visible = true;
                //this.Close();
                Application.Restart();
                return;
            }
            else MessageBox.Show("적립 여부를 먼저 선택해주세요!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
