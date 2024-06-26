namespace WinForms_Pang_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnGoBack = new System.Windows.Forms.Button();
            btnTicket = new System.Windows.Forms.Button();
            btnExit2 = new System.Windows.Forms.Button();
            btnReserOut = new System.Windows.Forms.Button();
            btnFood = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new System.Drawing.Point(351, 12);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new System.Drawing.Size(89, 44);
            btnGoBack.TabIndex = 0;
            btnGoBack.Text = "Home";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // btnTicket
            // 
            btnTicket.Location = new System.Drawing.Point(45, 175);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new System.Drawing.Size(136, 102);
            btnTicket.TabIndex = 1;
            btnTicket.Text = "티켓 구매";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnExit2
            // 
            btnExit2.Location = new System.Drawing.Point(457, 12);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new System.Drawing.Size(89, 44);
            btnExit2.TabIndex = 2;
            btnExit2.Text = "종료";
            btnExit2.UseVisualStyleBackColor = true;
            btnExit2.Click += btnExit2_Click;
            // 
            // btnReserOut
            // 
            btnReserOut.Location = new System.Drawing.Point(223, 175);
            btnReserOut.Name = "btnReserOut";
            btnReserOut.Size = new System.Drawing.Size(136, 102);
            btnReserOut.TabIndex = 3;
            btnReserOut.Text = "예매내역출력";
            btnReserOut.UseVisualStyleBackColor = true;
            btnReserOut.Click += btnReserOut_Click;
            // 
            // btnFood
            // 
            btnFood.Location = new System.Drawing.Point(393, 175);
            btnFood.Name = "btnFood";
            btnFood.Size = new System.Drawing.Size(136, 102);
            btnFood.TabIndex = 4;
            btnFood.Text = "음식 주문";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(125, 70);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.DimGray;
            ClientSize = new System.Drawing.Size(563, 300);
            Controls.Add(pictureBox1);
            Controls.Add(btnFood);
            Controls.Add(btnReserOut);
            Controls.Add(btnExit2);
            Controls.Add(btnTicket);
            Controls.Add(btnGoBack);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnExit2;
        private System.Windows.Forms.Button btnReserOut;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}