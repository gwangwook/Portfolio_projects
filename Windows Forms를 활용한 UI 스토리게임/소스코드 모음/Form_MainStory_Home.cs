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
using TeamProject_part2;

namespace Group5_TeamProject
{
    public partial class Form_MainStory_Home : Form
    {
        private bool isProcessing = false;
        static public List<string> commu1 = new List<string>(); // TextBox 대화 리스트
        static public int a = 0;
        static public List<string> Item = new List<string> { "휴대폰", "헤드셋", "카드", "USB" }; // 인벤토리에 들어갈 요소
        static public List<string> Inventory = new List<string>();  // 인벤토리 저장 리스트
        static public int object_Count = 0;

        Bitmap after = new Bitmap(@"C:\C#\WinForm_TeamProject_Group5\project_image\Professor after-remove.png");

        public Form_MainStory_Home()
        {
            InitializeComponent();
            commu1.Add("......");
            commu1.Add("(아침에 눈을 떴다.)");
            commu1.Add("오늘은 날씨가 굉장히 좋네~");
            commu1.Add("여유롭게 일어났으니 아침밥을 먹어볼까?");
            commu1.Add("(냉장고를 확인한다)");
            commu1.Add("어라? 비밀번호가 다르잖아?");
            commu1.Add("System : 냉장고를 클릭하세요");  // 교수님 안보이게 6
            commu1.Add("아침 식사를 완료했다. 이제 출근준비를 하자.");
            commu1.Add("출근 준비를 다 했다. 무엇을 들고 나갈까?");
            commu1.Add("System : 가지고 나갈 물건을 고르세요"); // 교수님 안보이게 9
            commu1.Add(""); // 아래서 a++ 두번 실행. 이거 건너뜀
            commu1.Add("System : 집에서 나갑니다.");   // 교수님 안보이게 11
        }
        private async Task DisplayTextWithDelay(string text, Label label, int delay)
        {
            for (int i = 0; i < text.Length; i++)
            {
                label.Text += text[i].ToString();
                await Task.Delay(delay);
            }
        }


        private void btn_Refrigenator_Click(object sender, EventArgs e)
        {
            if (label1.Text == "System : 냉장고를 클릭하세요")
            {
                Form_lock_Event lock_event = new Form_lock_Event();
                lock_event.Show();
            }
        }

        private void btn_Refrigenator_MouseHover(object sender, EventArgs e)    // 냉장고 커서 위치 시 부가설명 확인 코드
        {
            this.toolTip1.ToolTipTitle = "냉장고";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.btn_Refrigenator, "아침식사를 위해 냉장고를 연다");
        }

        private void btn_Phone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("휴대폰을 발견했다. 챙기시겠습니까?", "Yes Or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("휴대폰을 챙깁니다.");
                Inventory.Add(Item[0]);

            }
            else
            {
                MessageBox.Show("휴대폰을 챙기지 않습니다.");
            }
        }

        private void btn_HeadPhone_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("헤드폰을 발견했다. 챙기시겠습니까?", "Yes Or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("헤드폰을 챙깁니다.");
                Inventory.Add(Item[1]);

            }
            else
            {
                MessageBox.Show("헤드폰을 챙기지 않습니다.");
            }
        }

        private void btn_Card_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("카드를 발견했다. 챙기시겠습니까?", "Yes Or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("카드를 챙깁니다.");
                Inventory.Add(Item[2]);

            }
            else
            {
                MessageBox.Show("카드를 챙기지 않습니다.");
            }
        }

        private void btn_Usb_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("USB를 발견했다. 챙기시겠습니까?", "Yes Or No", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("USB를 챙깁니다.");
                Inventory.Add(Item[3]);
            }
            else
            {
                MessageBox.Show("USB를 챙기지 않습니다.");
            }
        }

        private void btn_Inventori_Input_Click(object sender, EventArgs e)
        {
            Form_Inventori Inventori = new Form_Inventori();
            Inventori.ShowDialog();
        }

        private void btn_Inventori_Input_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "인벤토리";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.btn_Inventori_Input, "장비창을 엽니다.");
        }


        private async void Text_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            int check = Form_lock_Event.lock_event;

            if (isProcessing)
            {
                return;
            }

            if (a == 12)
            {
                Step2 step2 = new Step2();
                step2.Show();
                this.Hide();
            }
            if (a < 8 && check == 1)
            {
                Form_Progressbar progressbar = new Form_Progressbar();
                progressbar.ShowDialog();
            }
            if (a == 8)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = after;
                pictureBox1.BringToFront();
                Text_Panel.BringToFront();
                label1.BringToFront();
            }
            if(a == 6 || a == 9 || a == 11)
            {
                pictureBox1.Image = null;
            }

            if (a == 7 && check == 0)
            {
                return;
            }
            if (a == 10 && object_Count == 0)
            {
                DialogResult result = MessageBox.Show($"다 챙기셨습니까?.", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    a++;
                }
                else if (result == DialogResult.No)
                {
                    MessageBox.Show("한번 더 고민해주세요.");
                    return;
                }
            }
            else if (a < commu1.Count)
            {
                string text = commu1[a];
                a++;

                isProcessing = true;
                await ProcessText(text);
                isProcessing = false;
            }
        }

        private async Task ProcessText(string text)
        {
            label1.Text = "";

            for (int i = 0; i < text.Length; i++)
            {
                label1.Text += text[i].ToString();
                await Task.Delay(10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}