namespace Group5_TeamProject
{
    partial class Form_GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GameOver));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_Explanation = new System.Windows.Forms.Button();
            btn_GameReStart = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-4, 480);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(392, 322);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Explanation
            // 
            btn_Explanation.BackColor = System.Drawing.Color.Transparent;
            btn_Explanation.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Explanation.FlatAppearance.BorderSize = 0;
            btn_Explanation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Explanation.Image = (System.Drawing.Image)resources.GetObject("btn_Explanation.Image");
            btn_Explanation.Location = new System.Drawing.Point(482, 576);
            btn_Explanation.Name = "btn_Explanation";
            btn_Explanation.Size = new System.Drawing.Size(225, 56);
            btn_Explanation.TabIndex = 6;
            btn_Explanation.UseVisualStyleBackColor = false;
            btn_Explanation.Click += btn_Explanation_Click;
            // 
            // btn_GameReStart
            // 
            btn_GameReStart.BackColor = System.Drawing.Color.Transparent;
            btn_GameReStart.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_GameReStart.FlatAppearance.BorderSize = 0;
            btn_GameReStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_GameReStart.Image = (System.Drawing.Image)resources.GetObject("btn_GameReStart.Image");
            btn_GameReStart.Location = new System.Drawing.Point(482, 480);
            btn_GameReStart.Name = "btn_GameReStart";
            btn_GameReStart.Size = new System.Drawing.Size(225, 52);
            btn_GameReStart.TabIndex = 5;
            btn_GameReStart.UseVisualStyleBackColor = false;
            btn_GameReStart.Click += btn_GameReStart_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(316, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(566, 115);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(316, 302);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(20, 25);
            label5.TabIndex = 11;
            label5.Text = "-";
            // 
            // Form_GameOver
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(label5);
            Controls.Add(btn_Explanation);
            Controls.Add(btn_GameReStart);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_GameOver";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_GameOver";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Explanation;
        private System.Windows.Forms.Button btn_GameReStart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}