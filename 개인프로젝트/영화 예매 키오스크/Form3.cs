using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_Pang_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void btnReservation_Click(object sender, EventArgs e)
        {
            if (radioZzang.Checked)
            {
                Form3_1_Zzang form3_1 = new Form3_1_Zzang();
                form3_1.Show();
                this.Close();
            }
            else if (radioSz.Checked)
            {
                MessageBox.Show("미구현");
            }
            else if (radioSubom.Checked)
            {
                MessageBox.Show("미구현");
            }
            else
            {
                MessageBox.Show("영화를 선택해주세요!");
            }
        }
    }
}
