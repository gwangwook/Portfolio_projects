namespace WinForms_Pang_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_reservation = new System.Windows.Forms.Label();
            btnStart = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnExit1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_reservation
            // 
            lbl_reservation.AutoSize = true;
            lbl_reservation.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_reservation.ForeColor = System.Drawing.Color.White;
            lbl_reservation.Location = new System.Drawing.Point(77, 99);
            lbl_reservation.Name = "lbl_reservation";
            lbl_reservation.Size = new System.Drawing.Size(324, 28);
            lbl_reservation.TabIndex = 0;
            lbl_reservation.Text = "Movie Reservation / Food Order";
            // 
            // btnStart
            // 
            btnStart.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStart.Location = new System.Drawing.Point(135, 193);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(202, 90);
            btnStart.TabIndex = 1;
            btnStart.Text = "시작하기";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(43, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(392, 20);
            label1.TabIndex = 2;
            label1.Text = "영화 예약 및 음식 주문을 원하신다면 아래를 클릭하세요.";
            // 
            // btnExit1
            // 
            btnExit1.Location = new System.Drawing.Point(382, 12);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new System.Drawing.Size(75, 44);
            btnExit1.TabIndex = 3;
            btnExit1.Text = "종료";
            btnExit1.UseVisualStyleBackColor = true;
            btnExit1.Click += btnExit1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(115, 59);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(469, 316);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit1);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(lbl_reservation);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_reservation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
