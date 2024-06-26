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
    public partial class Form_Inventori : Form
    {

        static public string Phone = @"C:\C#\WinForm_TeamProject_Group5\project_image\Phone-remove.png";
        static public string Head_Phone = @"C:\C#\WinForm_TeamProject_Group5\project_image\head_Phone-remove.png";
        static public string Card = @"C:\C#\WinForm_TeamProject_Group5\project_image\Card_remove.png";
        static public string Usb = @"C:\C#\WinForm_TeamProject_Group5\project_image\USB-remove.png";
        public Form_Inventori()
        {
            InitializeComponent();
            List<string> items = Form_MainStory_Home.Item;  // 아이템 리스트 불러오기
            List<string> Inventoris = Form_MainStory_Home.Inventory; // 인벤토리 리스트 불러오기

            if (Form_MainStory_Home.Inventory.Contains(items[0]))  // 인벤토리에 휴대폰 요소가 추가되어 있으면,
            {
                Inven1.Image = new Bitmap(Phone);
            }
            if (Form_MainStory_Home.Inventory.Contains(items[1]))  // 인벤토리에 헤드폰 요소가 추가되어 있으면,
            {
                Inven2.Image = new Bitmap(Head_Phone);
            }
            if (Form_MainStory_Home.Inventory.Contains(items[2]))  // 인벤토리에 카드 요소가 추가되어 있으면,
            {
                Inven3.Image = new Bitmap(Card);
            }
            if (Form_MainStory_Home.Inventory.Contains(items[3]))  // 인벤토리에 USb 요소가 추가되어 있으면,
            {
                Inven4.Image = new Bitmap(Usb);
            }

        }

        private void Inven1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장착하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장착되었습니다.");
                Inven1.Image = null;    // 인벤토리 칸 비우고

                Equ1.Image = new Bitmap(Phone); // 아래 장비칸에 이미지 추가

            }
            else
            {
                MessageBox.Show("장착하지 않습니다.");
            }
        }

        private void Inven2_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장착하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장착되었습니다.");
                Inven2.Image = null;

                Equ2.Image = new Bitmap(Head_Phone);

            }
            else
            {
                MessageBox.Show("장착하지 않습니다.");
            }
        }

        private void Inven3_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장착하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장착되었습니다.");
                Inven3.Image = null;

                Equ3.Image = new Bitmap(Card);

            }
            else
            {
                MessageBox.Show("장착하지 않습니다.");
            }
        }

        private void Inven4_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("장착하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("장착되었습니다.");
                Inven4.Image = null;

                Equ4.Image = new Bitmap(Usb);

            }
            else
            {
                MessageBox.Show("장착하지 않습니다.");
            }
        }
    }
}
