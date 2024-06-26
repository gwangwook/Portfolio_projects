namespace WinForms_Pang_Project
{
    partial class Form3_1_Zzang_Pay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_1_Zzang_Pay));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btnEnter1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioDisagree = new System.Windows.Forms.RadioButton();
            radioAgree = new System.Windows.Forms.RadioButton();
            label7 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            btnPay = new System.Windows.Forms.Button();
            lbPayInfo = new System.Windows.Forms.ListBox();
            cbPay = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            btnCancel = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(47, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "좌석 수:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(28, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 25);
            label2.TabIndex = 0;
            label2.Text = "결제 금액:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Location = new System.Drawing.Point(134, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(23, 25);
            label3.TabIndex = 0;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(134, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(23, 25);
            label4.TabIndex = 0;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(207, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(31, 25);
            label5.TabIndex = 0;
            label5.Text = "원";
            // 
            // btnEnter1
            // 
            btnEnter1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEnter1.Location = new System.Drawing.Point(276, 123);
            btnEnter1.Name = "btnEnter1";
            btnEnter1.Size = new System.Drawing.Size(75, 27);
            btnEnter1.TabIndex = 10;
            btnEnter1.Text = "확인";
            btnEnter1.UseVisualStyleBackColor = true;
            btnEnter1.Click += btnEnter1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDisagree);
            groupBox1.Controls.Add(radioAgree);
            groupBox1.Location = new System.Drawing.Point(18, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(333, 70);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "적립 여부";
            // 
            // radioDisagree
            // 
            radioDisagree.AutoSize = true;
            radioDisagree.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioDisagree.Location = new System.Drawing.Point(172, 31);
            radioDisagree.Name = "radioDisagree";
            radioDisagree.Size = new System.Drawing.Size(78, 21);
            radioDisagree.TabIndex = 0;
            radioDisagree.TabStop = true;
            radioDisagree.Text = "적립안함";
            radioDisagree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            radioAgree.AutoSize = true;
            radioAgree.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            radioAgree.Location = new System.Drawing.Point(64, 31);
            radioAgree.Name = "radioAgree";
            radioAgree.Size = new System.Drawing.Size(52, 21);
            radioAgree.TabIndex = 0;
            radioAgree.TabStop = true;
            radioAgree.Text = "적립";
            radioAgree.UseVisualStyleBackColor = true;
            radioAgree.CheckedChanged += radioAgree_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(207, 11);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(31, 25);
            label7.TabIndex = 0;
            label7.Text = "명";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(77, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(193, 25);
            textBox1.TabIndex = 11;
            textBox1.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(11, 123);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(60, 17);
            label8.TabIndex = 12;
            label8.Text = "회원번호";
            label8.Visible = false;
            // 
            // btnPay
            // 
            btnPay.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPay.Location = new System.Drawing.Point(276, 81);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(75, 23);
            btnPay.TabIndex = 19;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // lbPayInfo
            // 
            lbPayInfo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Items.AddRange(new object[] { " " });
            lbPayInfo.Location = new System.Drawing.Point(140, 81);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new System.Drawing.Size(128, 64);
            lbPayInfo.TabIndex = 18;
            // 
            // cbPay
            // 
            cbPay.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "페이결제", "카드결제" });
            cbPay.Location = new System.Drawing.Point(27, 81);
            cbPay.Name = "cbPay";
            cbPay.Size = new System.Drawing.Size(100, 23);
            cbPay.TabIndex = 17;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(140, 49);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(69, 20);
            label9.TabIndex = 15;
            label9.Text = "결제정보";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(27, 49);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 20);
            label10.TabIndex = 16;
            label10.Text = "결제방법";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEnter1);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(12, 104);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(372, 164);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "L.Point 적립";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(cbPay);
            groupBox3.Controls.Add(btnPay);
            groupBox3.Controls.Add(lbPayInfo);
            groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox3.Location = new System.Drawing.Point(12, 306);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(372, 155);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "결제";
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Location = new System.Drawing.Point(303, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(81, 35);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "결제취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form3_1_Zzang_Pay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 491);
            Controls.Add(btnCancel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form3_1_Zzang_Pay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3_1_Zzang_Pay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnter1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDisagree;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ListBox lbPayInfo;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancel;
    }
}