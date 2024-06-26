using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform_TeamProject;

namespace Group5_TeamProject
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void btn_GameStart_Click(object sender, EventArgs e)
        {
            Form_MainStory_Home form_Home = new Form_MainStory_Home();

            form_Home.Show();
            this.Visible = false;

        }

        private void btn_Explanation_Click(object sender, EventArgs e)
        {
            Form_Ex form_ex = new Form_Ex();
            form_ex.Show();

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
