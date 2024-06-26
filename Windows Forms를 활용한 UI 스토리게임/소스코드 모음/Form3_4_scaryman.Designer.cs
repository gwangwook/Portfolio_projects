namespace _3_1
{
    partial class Form3_4_scaryman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_4_scaryman));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tb_answer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lb_minute = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(230, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(500, 400);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tb_answer
            // 
            tb_answer.Location = new System.Drawing.Point(374, 562);
            tb_answer.Name = "tb_answer";
            tb_answer.Size = new System.Drawing.Size(163, 23);
            tb_answer.TabIndex = 2;
            tb_answer.KeyDown += tb_answer_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(301, 565);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "정답 : ";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(856, 693);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(116, 56);
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
            // lb_minute
            // 
            lb_minute.AutoSize = true;
            lb_minute.Location = new System.Drawing.Point(755, 12);
            lb_minute.Name = "lb_minute";
            lb_minute.Size = new System.Drawing.Size(14, 15);
            lb_minute.TabIndex = 5;
            lb_minute.Text = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(683, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "제한시간 : ";
            // 
            // Form3_4_scaryman
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 761);
            Controls.Add(label5);
            Controls.Add(lb_minute);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(tb_answer);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form3_4_scaryman";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form3_4_scaryman";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lb_minute;
        private System.Windows.Forms.Label label5;
    }
}