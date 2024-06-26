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
    public partial class Form_GameOver : Form
    {
        public static string gameover = "";
        public Form_GameOver()
        {
            InitializeComponent();
            label5.Text = gameover;
        }

        private void btn_GameReStart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_Explanation_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}