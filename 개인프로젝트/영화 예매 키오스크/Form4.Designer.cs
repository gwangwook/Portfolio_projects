namespace WinForms_Pang_Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            btnExit = new System.Windows.Forms.Button();
            btnGoBack = new System.Windows.Forms.Button();
            listView1 = new System.Windows.Forms.ListView();
            movieTitle = new System.Windows.Forms.ColumnHeader();
            movieTheater = new System.Windows.Forms.ColumnHeader();
            movieTime = new System.Windows.Forms.ColumnHeader();
            movieSeat = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbNumber = new System.Windows.Forms.TextBox();
            btnInquiry = new System.Windows.Forms.Button();
            btnRSCancel = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            labelagenumber = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(577, 23);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(73, 44);
            btnExit.TabIndex = 5;
            btnExit.Text = "종료";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new System.Drawing.Point(489, 23);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new System.Drawing.Size(71, 44);
            btnGoBack.TabIndex = 4;
            btnGoBack.Text = "Home";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // listView1
            // 
            listView1.BackColor = System.Drawing.Color.DimGray;
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { movieTitle, movieTheater, movieTime, movieSeat });
            listView1.ForeColor = System.Drawing.Color.White;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new System.Drawing.Point(81, 125);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(503, 382);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // movieTitle
            // 
            movieTitle.Text = "제목";
            movieTitle.Width = 200;
            // 
            // movieTheater
            // 
            movieTheater.Text = "상영관";
            movieTheater.Width = 100;
            // 
            // movieTime
            // 
            movieTime.Text = "시간";
            movieTime.Width = 100;
            // 
            // movieSeat
            // 
            movieSeat.Text = "좌석";
            movieSeat.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(252, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(171, 25);
            label1.TabIndex = 7;
            label1.Text = "예매내역 출력하기";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Transparent;
            label2.Location = new System.Drawing.Point(82, 548);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 21);
            label2.TabIndex = 8;
            label2.Text = "전화번호";
            // 
            // tbNumber
            // 
            tbNumber.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tbNumber.Location = new System.Drawing.Point(162, 545);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new System.Drawing.Size(212, 29);
            tbNumber.TabIndex = 9;
            // 
            // btnInquiry
            // 
            btnInquiry.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnInquiry.Location = new System.Drawing.Point(393, 527);
            btnInquiry.Name = "btnInquiry";
            btnInquiry.Size = new System.Drawing.Size(91, 62);
            btnInquiry.TabIndex = 10;
            btnInquiry.Text = "조회";
            btnInquiry.UseVisualStyleBackColor = true;
            btnInquiry.Click += btnInquiry_Click;
            // 
            // btnRSCancel
            // 
            btnRSCancel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRSCancel.ForeColor = System.Drawing.Color.Red;
            btnRSCancel.Location = new System.Drawing.Point(499, 527);
            btnRSCancel.Name = "btnRSCancel";
            btnRSCancel.Size = new System.Drawing.Size(91, 62);
            btnRSCancel.TabIndex = 10;
            btnRSCancel.Text = "예매 취소";
            btnRSCancel.UseVisualStyleBackColor = true;
            btnRSCancel.Click += btnRSCancel_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.Location = new System.Drawing.Point(81, 614);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(240, 43);
            button1.TabIndex = 11;
            button1.Text = "전체 예매표 출력하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Transparent;
            button2.Location = new System.Drawing.Point(344, 614);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(240, 43);
            button2.TabIndex = 11;
            button2.Text = "선택 예매표 출력하기";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelagenumber
            // 
            labelagenumber.AutoSize = true;
            labelagenumber.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelagenumber.ForeColor = System.Drawing.Color.Transparent;
            labelagenumber.Location = new System.Drawing.Point(518, 96);
            labelagenumber.Name = "labelagenumber";
            labelagenumber.Size = new System.Drawing.Size(52, 17);
            labelagenumber.TabIndex = 7;
            labelagenumber.Text = "인원 수";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(31, 23);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(125, 70);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(672, 680);
            Controls.Add(pictureBox4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnRSCancel);
            Controls.Add(btnInquiry);
            Controls.Add(tbNumber);
            Controls.Add(label2);
            Controls.Add(labelagenumber);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btnExit);
            Controls.Add(btnGoBack);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader movieTitle;
        private System.Windows.Forms.ColumnHeader movieTheater;
        private System.Windows.Forms.ColumnHeader movieTime;
        private System.Windows.Forms.ColumnHeader movieSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Button btnRSCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelagenumber;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}