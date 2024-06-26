namespace Winform_TeamProject
{
    partial class Form_Moble
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Moble));
            btn_Search = new System.Windows.Forms.Button();
            Text_Panel = new System.Windows.Forms.Panel();
            btn_Call_911 = new System.Windows.Forms.Button();
            btn_run = new System.Windows.Forms.Button();
            btn_commu15_no = new System.Windows.Forms.Button();
            btn_commu_yes = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Exit = new System.Windows.Forms.Button();
            Text_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Search
            // 
            btn_Search.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Search.ForeColor = System.Drawing.Color.Black;
            btn_Search.Location = new System.Drawing.Point(980, 610);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new System.Drawing.Size(136, 43);
            btn_Search.TabIndex = 1;
            btn_Search.Text = "증거 찾기";
            btn_Search.UseVisualStyleBackColor = false;
            btn_Search.Visible = false;
            btn_Search.Click += btn_GoEvent1_Click;
            // 
            // Text_Panel
            // 
            Text_Panel.BackColor = System.Drawing.Color.Transparent;
            Text_Panel.BackgroundImage = (System.Drawing.Image)resources.GetObject("Text_Panel.BackgroundImage");
            Text_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Text_Panel.Controls.Add(btn_Call_911);
            Text_Panel.Controls.Add(btn_run);
            Text_Panel.Controls.Add(btn_commu15_no);
            Text_Panel.Controls.Add(btn_commu_yes);
            Text_Panel.Controls.Add(pictureBox3);
            Text_Panel.Controls.Add(label1);
            Text_Panel.Location = new System.Drawing.Point(69, 659);
            Text_Panel.Name = "Text_Panel";
            Text_Panel.Size = new System.Drawing.Size(1056, 152);
            Text_Panel.TabIndex = 13;
            Text_Panel.MouseDown += Text_Panel_MouseDown;
            // 
            // btn_Call_911
            // 
            btn_Call_911.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_Call_911.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Call_911.ForeColor = System.Drawing.Color.Black;
            btn_Call_911.Location = new System.Drawing.Point(157, 83);
            btn_Call_911.Name = "btn_Call_911";
            btn_Call_911.Size = new System.Drawing.Size(112, 40);
            btn_Call_911.TabIndex = 15;
            btn_Call_911.Text = "신고한다";
            btn_Call_911.UseVisualStyleBackColor = false;
            btn_Call_911.Visible = false;
            btn_Call_911.Click += btn_Call_911_Click;
            // 
            // btn_run
            // 
            btn_run.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_run.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_run.ForeColor = System.Drawing.Color.Black;
            btn_run.Location = new System.Drawing.Point(30, 83);
            btn_run.Name = "btn_run";
            btn_run.Size = new System.Drawing.Size(112, 40);
            btn_run.TabIndex = 14;
            btn_run.Text = "도망간다";
            btn_run.UseVisualStyleBackColor = false;
            btn_run.Visible = false;
            btn_run.Click += btn_run_Click;
            // 
            // btn_commu15_no
            // 
            btn_commu15_no.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_commu15_no.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_commu15_no.ForeColor = System.Drawing.Color.Black;
            btn_commu15_no.Location = new System.Drawing.Point(780, 83);
            btn_commu15_no.Name = "btn_commu15_no";
            btn_commu15_no.Size = new System.Drawing.Size(100, 40);
            btn_commu15_no.TabIndex = 13;
            btn_commu15_no.Text = "아니오";
            btn_commu15_no.UseVisualStyleBackColor = false;
            btn_commu15_no.Visible = false;
            btn_commu15_no.Click += btn_commu15_no_Click;
            // 
            // btn_commu_yes
            // 
            btn_commu_yes.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_commu_yes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_commu_yes.ForeColor = System.Drawing.Color.Black;
            btn_commu_yes.Location = new System.Drawing.Point(780, 37);
            btn_commu_yes.Name = "btn_commu_yes";
            btn_commu_yes.Size = new System.Drawing.Size(100, 40);
            btn_commu_yes.TabIndex = 12;
            btn_commu_yes.Text = "예";
            btn_commu_yes.UseVisualStyleBackColor = false;
            btn_commu_yes.Visible = false;
            btn_commu_yes.Click += btn_commu_yes_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(952, 46);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(82, 93);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(30, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 40);
            label1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(46, 506);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(258, 170);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Location = new System.Drawing.Point(867, 459);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(258, 217);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.Location = new System.Drawing.Point(1041, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(104, 44);
            btn_Exit.TabIndex = 16;
            btn_Exit.Text = "종료하기";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Form_Moble
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(btn_Exit);
            Controls.Add(Text_Panel);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Search);
            Controls.Add(pictureBox2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_Moble";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_Moble";
            Text_Panel.ResumeLayout(false);
            Text_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel Text_Panel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_commu_yes;
        private System.Windows.Forms.Button btn_commu15_no;
        private System.Windows.Forms.Button btn_Call_911;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Exit;
    }
}