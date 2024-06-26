namespace Group5_TeamProject
{
    partial class Form_Ex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ex));
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            P_B_Roll = new System.Windows.Forms.PictureBox();
            pictureBox = new System.Windows.Forms.PictureBox();
            btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P_B_Roll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.ForeColor = System.Drawing.SystemColors.ControlText;
            label1.Image = (System.Drawing.Image)resources.GetObject("label1.Image");
            label1.Location = new System.Drawing.Point(374, 67);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 49);
            label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(772, 606);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 157);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // P_B_Roll
            // 
            P_B_Roll.BackColor = System.Drawing.Color.Transparent;
            P_B_Roll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            P_B_Roll.Location = new System.Drawing.Point(134, 119);
            P_B_Roll.Name = "P_B_Roll";
            P_B_Roll.Size = new System.Drawing.Size(639, 644);
            P_B_Roll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            P_B_Roll.TabIndex = 2;
            P_B_Roll.TabStop = false;
            P_B_Roll.Click += P_B_Roll_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = System.Drawing.Color.Transparent;
            pictureBox.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox.BackgroundImage");
            pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox.Image = (System.Drawing.Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new System.Drawing.Point(276, 205);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(361, 478);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Visible = false;
            // 
            // btn_exit
            // 
            btn_exit.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_exit.Location = new System.Drawing.Point(730, 642);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(75, 23);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "닫기";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form_Ex
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(934, 961);
            Controls.Add(btn_exit);
            Controls.Add(pictureBox);
            Controls.Add(P_B_Roll);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_Ex";
            Text = "Form1_Ex";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)P_B_Roll).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox P_B_Roll;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_exit;
    }
}