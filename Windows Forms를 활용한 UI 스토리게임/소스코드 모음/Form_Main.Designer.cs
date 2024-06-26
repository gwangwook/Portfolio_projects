namespace Group5_TeamProject
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btn_GameStart = new System.Windows.Forms.Button();
            btn_Explanation = new System.Windows.Forms.Button();
            btn_Exit = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(243, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(713, 168);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(856, 523);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(140, 163);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btn_GameStart
            // 
            btn_GameStart.BackColor = System.Drawing.Color.Transparent;
            btn_GameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_GameStart.FlatAppearance.BorderSize = 0;
            btn_GameStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_GameStart.Image = (System.Drawing.Image)resources.GetObject("btn_GameStart.Image");
            btn_GameStart.Location = new System.Drawing.Point(471, 440);
            btn_GameStart.Name = "btn_GameStart";
            btn_GameStart.Size = new System.Drawing.Size(225, 44);
            btn_GameStart.TabIndex = 2;
            btn_GameStart.UseVisualStyleBackColor = false;
            btn_GameStart.Click += btn_GameStart_Click;
            // 
            // btn_Explanation
            // 
            btn_Explanation.BackColor = System.Drawing.Color.Transparent;
            btn_Explanation.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Explanation.FlatAppearance.BorderSize = 0;
            btn_Explanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Explanation.Image = (System.Drawing.Image)resources.GetObject("btn_Explanation.Image");
            btn_Explanation.Location = new System.Drawing.Point(471, 523);
            btn_Explanation.Name = "btn_Explanation";
            btn_Explanation.Size = new System.Drawing.Size(225, 44);
            btn_Explanation.TabIndex = 3;
            btn_Explanation.UseVisualStyleBackColor = false;
            btn_Explanation.Click += btn_Explanation_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.Transparent;
            btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Image = (System.Drawing.Image)resources.GetObject("btn_Exit.Image");
            btn_Exit.Location = new System.Drawing.Point(471, 602);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(225, 44);
            btn_Exit.TabIndex = 4;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(147, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(255, 263);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(pictureBox3);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Explanation);
            Controls.Add(btn_GameStart);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_Main";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_GameStart;
        private System.Windows.Forms.Button btn_Explanation;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
