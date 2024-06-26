namespace WinForms_Pang_Project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new System.Windows.Forms.Label();
            btnGoBack = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnReservation = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            radioZzang = new System.Windows.Forms.RadioButton();
            radioSz = new System.Windows.Forms.RadioButton();
            radioSubom = new System.Windows.Forms.RadioButton();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            groupBox1 = new System.Windows.Forms.GroupBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(154, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(251, 37);
            label1.TabIndex = 0;
            label1.Text = "영화를 선택하세요!";
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new System.Drawing.Point(920, 18);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new System.Drawing.Size(89, 44);
            btnGoBack.TabIndex = 1;
            btnGoBack.Text = "Home";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(1028, 18);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(89, 44);
            btnExit.TabIndex = 3;
            btnExit.Text = "종료";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReservation
            // 
            btnReservation.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnReservation.Location = new System.Drawing.Point(470, 565);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new System.Drawing.Size(189, 65);
            btnReservation.TabIndex = 5;
            btnReservation.Text = "예매하기";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(48, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(285, 350);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(402, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(285, 350);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(760, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(285, 350);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // radioZzang
            // 
            radioZzang.AutoSize = true;
            radioZzang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            radioZzang.Location = new System.Drawing.Point(107, 405);
            radioZzang.Name = "radioZzang";
            radioZzang.Size = new System.Drawing.Size(172, 24);
            radioZzang.TabIndex = 1;
            radioZzang.TabStop = true;
            radioZzang.Text = "짱구는 못말려 극장판";
            radioZzang.UseVisualStyleBackColor = true;
            // 
            // radioSz
            // 
            radioSz.AutoSize = true;
            radioSz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            radioSz.Location = new System.Drawing.Point(463, 405);
            radioSz.Name = "radioSz";
            radioSz.Size = new System.Drawing.Size(192, 24);
            radioSz.TabIndex = 1;
            radioSz.TabStop = true;
            radioSz.Text = "스즈메의 문단속(번역판)";
            radioSz.UseVisualStyleBackColor = true;
            // 
            // radioSubom
            // 
            radioSubom.AutoSize = true;
            radioSubom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            radioSubom.Location = new System.Drawing.Point(869, 405);
            radioSubom.Name = "radioSubom";
            radioSubom.Size = new System.Drawing.Size(92, 24);
            radioSubom.TabIndex = 1;
            radioSubom.TabStop = true;
            radioSubom.Text = "서울의 봄";
            radioSubom.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = System.Drawing.Color.White;
            linkLabel2.Location = new System.Drawing.Point(130, 407);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(0, 20);
            linkLabel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.Color.DimGray;
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(radioSubom);
            groupBox1.Controls.Add(radioSz);
            groupBox1.Controls.Add(radioZzang);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox1.Location = new System.Drawing.Point(24, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1093, 448);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "현재 상영중인 영화목록";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(24, 18);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(125, 70);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(1143, 653);
            Controls.Add(pictureBox4);
            Controls.Add(btnReservation);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnGoBack);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioZzang;
        private System.Windows.Forms.RadioButton radioSz;
        private System.Windows.Forms.RadioButton radioSubom;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}