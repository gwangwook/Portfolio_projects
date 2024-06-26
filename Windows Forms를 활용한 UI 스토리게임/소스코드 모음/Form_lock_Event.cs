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

namespace Group5_TeamProject
{
    public partial class Form_lock_Event : Form
    {
        public static int lock_event = 0;
        string image2 = @"C:\C#\WinForm_TeamProject_Group5\project_image\Refrigerator_Lock_On-remove.png";
        string image3 = @"C:\C#\WinForm_TeamProject_Group5\project_image\Refrigerator_Lock_off-remove.png";
        public Form_lock_Event()
        {
            InitializeComponent();
            MessageBox.Show("냉장고를 열려면 냉장고 자물쇠 비밀번호를 맞춰야 합니다!\n비밀번호는 세자리입니다.");
            p_b_OnOff.Image = new Bitmap(image2);

        }
        List<string> password = new List<string> { "btn1", "btn7", "btn5" };    // 버튼 이름으로 비밀번호 지정
        static public List<string> userInput = new List<string>();    // 입력한 버튼 저장할 깡통리스트 userInput으로 생성

        private void button1_Click(object sender, EventArgs e)
        {
            string image = @"C:\C#\WinForm_TeamProject_Group5\project_image\post_it-remove1.png";

            try
            {
                pictureBox1.Image = new Bitmap(image); // 이미지 경로 불러서 넣기
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // 예외발생 시 x
            }
        }

        private void AllButtons_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;  // sender 매개변수는 C#에 이벤트헨들러에 이미 존재. 이벤트 발신자를 참조함.
            userInput.Add(clickedButton.Name);

            if (userInput.Count == password.Count)
            {
                if (userInput.SequenceEqual(password))  // 비밀번호가 맞는지 확인, SequenceEqual()은 두 객체가 동일한지 확인하는 메서드.
                {
                    MessageBox.Show("비밀번호가 맞습니다!");
                    p_b_OnOff.Image = new Bitmap(image3);
                    MessageBox.Show("냉장고 문을 열었습니다!");
                    MessageBox.Show("아침 식사 완료!");
                    lock_event = 1;
                    ;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호가 틀렸습니다!");
                }
                userInput.Clear();  // 사용자 입력 초기화

            }
        }

        private void btn_post_it_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "포스트잇";    // toolTip1 < 도구 상자에 존재하는 도구
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.btn_post_it, "남편이 출근 전에 붙이고 간 포스트잇으로 보인다.");
        }

        private void p_b_OnOff_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "냉장고";    // toolTip1 < 도구 상자에 존재하는 도구
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.p_b_OnOff, "냉장고 비밀번호가 변경되어 있다. 힌트를 찾아 냉장고를 열어보자.");
        }
    }
}
