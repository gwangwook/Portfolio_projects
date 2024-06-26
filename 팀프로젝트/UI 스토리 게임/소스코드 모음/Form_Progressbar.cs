using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_TeamProject
{
    public partial class Form_Progressbar : Form
    {
        public Form_Progressbar()
        {
            InitializeComponent();

            timer1.Start();
            label1.Text = "";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value+=4;

            label1.Text = "출근준비중입니다...";

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                label1.Text = "출근 준비 완료!";
                MessageBox.Show("출근 준비를 마쳤습니다.");
                this.Close();
            }
        }

          

    }
}


