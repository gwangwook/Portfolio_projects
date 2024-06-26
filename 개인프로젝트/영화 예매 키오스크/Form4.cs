using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinForms_Pang_Project
{
    public partial class Form4 : Form
    {
        public static int AdultCount = 0;
        public static int KidsCount = 0;
        public Form4()
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

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == "")
            {
                MessageBox.Show("조회할 전화번호를 입력하세요!\n전화번호는 띄어쓰기 혹은 -를 사용하지 않고 " +
                    "숫자만 입력하세요." + "\n예시) 01012345678");
            }
            else if (tbNumber.Text == "01012345678")
            {
                AdultCount = 0;
                KidsCount = 0;
                listView1.Items.Clear();
                MessageBox.Show("조회되었습니다.");
                labelagenumber.Text = $"성인{AdultCount = 2}명 어린이 {KidsCount = 4}명";
            listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "A열 1" }));
                listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "A열 2" }));
                listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "A열 3" }));
                listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "A열 4" }));
                listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "B열 1" }));
                listView1.Items.Add(new ListViewItem(new string[] { "짱구는 못말려 극장판", "1관", "10:30", "B열 2" }));
                tbNumber.Text = "";
            }
            else if (tbNumber.Text == "01087654321")
            {
                AdultCount = 0;
                KidsCount = 0;
                listView1.Items.Clear();
                MessageBox.Show("조회되었습니다.");
                labelagenumber.Text = $"성인{AdultCount = 2}명 어린이 {KidsCount = 0}명";
                listView1.Items.Add(new ListViewItem(new string[] { "스즈메의 문단속(번역판)", "3관", "19:00", "C열 5" }));
                listView1.Items.Add(new ListViewItem(new string[] { "스즈메의 문단속(번역판)", "3관", "19:00", "C열 6" }));
                tbNumber.Text = "";
            }
            else if (tbNumber.Text == "01011111111")
            {
                AdultCount = 0;
                KidsCount = 0;
                listView1.Items.Clear();
                MessageBox.Show("조회되었습니다.");
                labelagenumber.Text = $"성인{AdultCount = 4}명 어린이 {KidsCount = 0}명";
                listView1.Items.Add(new ListViewItem(new string[] { "서울의 봄", "3관", "12:00", "C열 3" }));
                listView1.Items.Add(new ListViewItem(new string[] { "서울의 봄", "3관", "12:00", "C열 4" }));
                listView1.Items.Add(new ListViewItem(new string[] { "서울의 봄", "3관", "12:00", "C열 5" }));
                listView1.Items.Add(new ListViewItem(new string[] { "서울의 봄", "3관", "12:00", "C열 6" }));
                tbNumber.Text = "";
            }
            else if (tbNumber.Text.Length != 11)
            {
                MessageBox.Show("잘못된 전화번호 형식입니다.\n전화번호는 띄어쓰기 혹은 -를 사용하지 않고 숫자만 입력하세요.");
            }
            else
            {
                MessageBox.Show("조회된 예매내역이 없습니다!");
            }
        }

        private void btnRSCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if(listView1.Items.Count == 0)
                {
                    MessageBox.Show("예매내역 조회 후 진행해주세요.");
                    return;
                }
                else
                {
                    int index = listView1.FocusedItem.Index;
                    string a = listView1.SelectedItems[0].SubItems[0].Text;
                    string b = listView1.SelectedItems[0].SubItems[1].Text;
                    string c = listView1.SelectedItems[0].SubItems[2].Text;
                    string d = listView1.SelectedItems[0].SubItems[3].Text;
                    DialogResult msgBox = MessageBox.Show($"영화제목: {a}\n상영관: {b}\n시간: {c}\n좌석: {d}\n" +
                        $"해당 좌석 예매취소를 진행합니다.\n취소할 인원이 성인이면 (예), 어린이면 (아니요)를 선택하세요."
                        , "예매 취소", MessageBoxButtons.YesNoCancel);
                    if (msgBox == DialogResult.Yes)
                    {
                        if (AdultCount > 0)
                        {
                            MessageBox.Show("예매 취소가 완료되었습니다.\n15000원이 환불됩니다." +
                                "\n환불 금액은 결제하신 계좌로 입금됩니다.");
                            listView1.Items.RemoveAt(index);
                            AdultCount--;
                            labelagenumber.Text = $"성인{AdultCount}명 어린이 {KidsCount}명";
                        }
                        else
                        {
                            MessageBox.Show("예매된 성인 좌석이 없습니다. 다시 확인해주세요!");
                            return;
                        }
                    }
                    else if (msgBox == DialogResult.No)
                    {
                        if (KidsCount > 0)
                        {
                            MessageBox.Show("예매 취소가 완료되었습니다.\n8000원이 환불됩니다." +
                                "\n환불 금액은 결제하신 계좌로 입금됩니다.");
                            listView1.Items.RemoveAt(index);
                            KidsCount--;
                            labelagenumber.Text = $"성인{AdultCount}명 어린이 {KidsCount}명";
                        }
                        else
                        {
                            MessageBox.Show("예매된 어린이 좌석이 없습니다. 다시 확인해주세요!");
                            return;
                        }
                    }
                    else if (msgBox == DialogResult.Cancel)
                    {
                        return;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("예매내역 조회 후 진행해주세요.");
                return;
            }
            else
            {
                DialogResult msgBox1 = MessageBox.Show("예매내역 전체를 출력하시겠습니까?", "전체 출력"
                    , MessageBoxButtons.YesNo);
                if (msgBox1 == DialogResult.Yes)
                {
                    int item_count = listView1.Items.Count;
                    for (int i = 0; i < item_count; i++)
                    {
                        MessageBox.Show($"\n영화제목: {listView1.Items[i].SubItems[0].Text}" + $"\n상영관: {listView1.Items[i].SubItems[1].Text}\n" +
                            $"시간: {listView1.Items[i].SubItems[2].Text}\n좌석: {listView1.Items[i].SubItems[3].Text}\n", $"예매표 {i + 1}");
                    }
                    MessageBox.Show("모든 예매표 출력을 완료했습니다.");
                    for(int i = 0; i < item_count; i++)
                        listView1.Items[0].Remove();
                    AdultCount = 0;
                    KidsCount = 0;
                    labelagenumber.Text = $"성인{AdultCount}명 어린이 {KidsCount}명";
                }
                else return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("예매내역 조회 후 진행해주세요.");
                return;
            }
            else if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("출력할 예매내역을 선택해주세요.");
            }
            else
            {
                DialogResult msgBox1 = MessageBox.Show("선택한 예매내역을 출력하시겠습니까?", "선택 출력"
                    , MessageBoxButtons.YesNo);
                if (msgBox1 == DialogResult.Yes)
                {
                    
                    int selecteditem_count = listView1.SelectedItems.Count;
                    for (int i = 0; i < selecteditem_count; i++)
                    {
                        DialogResult msgBox2 = MessageBox.Show($"\n영화제목: {listView1.SelectedItems[i].SubItems[0].Text}" + $"\n상영관: " +
                            $"{listView1.SelectedItems[i].SubItems[1].Text}\n시간: {listView1.SelectedItems[i].SubItems[2].Text}" +
                            $"\n좌석: {listView1.Items[i].SubItems[3].Text}\n(성인용 표면 Yes, 어린이용 표면 No를 선택)"
                            , $"예매표 {i + 1}", MessageBoxButtons.YesNo);
                        if (msgBox2 == DialogResult.Yes)
                        {
                            if (AdultCount > 0)
                                AdultCount--;
                            else
                            {
                                MessageBox.Show("더 이상 예매된 성인 좌석표가 없거나 취소하려는 성인 예매표보다 적습니다." +
                                    "\n다시 확인해주세요!");
                                return;
                            }
                        }
                        else if (msgBox2 == DialogResult.No)
                        {
                            if (KidsCount > 0)
                                KidsCount--;
                            else
                            {
                                MessageBox.Show("더 이상 예매된 어린이 좌석표가 없거나 취소하려는 어린이 예매표보다 " +
                                    "적습니다.\n다시 확인해주세요!");
                                return;
                            }
                        }
                    }
                    MessageBox.Show("선택 예매표 출력을 완료했습니다.");
                    for (int i = 0; i < selecteditem_count; i++)
                        listView1.SelectedItems[0].Remove();
                    labelagenumber.Text = $"성인{AdultCount}명 어린이 {KidsCount}명";
                }
                else return;
            }
        }
    }
}
