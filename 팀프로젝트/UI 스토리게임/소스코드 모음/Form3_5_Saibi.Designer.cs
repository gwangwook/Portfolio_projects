namespace _3_1
{
    partial class Form3_5_Saibi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_5_Saibi));
            tb_answer = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label5 = new System.Windows.Forms.Label();
            lb_minute = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_answer
            // 
            tb_answer.Location = new System.Drawing.Point(416, 598);
            tb_answer.Name = "tb_answer";
            tb_answer.Size = new System.Drawing.Size(144, 23);
            tb_answer.TabIndex = 2;
            tb_answer.KeyDown += textBox1_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(320, 590);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 30);
            label3.TabIndex = 3;
            label3.Text = "정답 : ";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(874, 699);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(98, 50);
            button1.TabIndex = 4;
            button1.Text = "포기하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(742, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 15);
            label5.TabIndex = 12;
            label5.Text = "제한시간 : ";
            // 
            // lb_minute
            // 
            lb_minute.AutoSize = true;
            lb_minute.Location = new System.Drawing.Point(814, 9);
            lb_minute.Name = "lb_minute";
            lb_minute.Size = new System.Drawing.Size(14, 15);
            lb_minute.TabIndex = 10;
            lb_minute.Text = "5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(218, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(500, 400);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form3_5_Saibi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 761);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(lb_minute);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(tb_answer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form3_5_Saibi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3_5_Saibi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_minute;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}