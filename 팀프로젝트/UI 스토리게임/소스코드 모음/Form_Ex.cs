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
    public partial class Form_Ex : Form
    {
        Bitmap Roll_Close = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\Roll_Close_remove.png");
        Bitmap Roll_Open = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\Roll_Open-remove.png");
        public Form_Ex()
        {
            InitializeComponent();
            P_B_Roll.Image = Roll_Close;
        }

        private void P_B_Roll_Click(object sender, EventArgs e)
        {
            P_B_Roll.Image = null;
            P_B_Roll.Image = Roll_Open;

            if (P_B_Roll.Image == Roll_Open)
            {
                pictureBox.Visible = true;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
