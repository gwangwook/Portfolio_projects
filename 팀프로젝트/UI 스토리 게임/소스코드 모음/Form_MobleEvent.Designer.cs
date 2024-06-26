namespace Winform_TeamProject
{
    partial class Form_MobleEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MobleEvent));
            lblQuestion = new System.Windows.Forms.Label();
            btn_HidingHint = new System.Windows.Forms.Button();
            btn_Exit = new System.Windows.Forms.Button();
            label_Enter = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btn_SignIn = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lb_minute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblQuestion.Location = new System.Drawing.Point(30, 28);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(0, 50);
            lblQuestion.TabIndex = 0;
            // 
            // btn_HidingHint
            // 
            btn_HidingHint.BackColor = System.Drawing.Color.Transparent;
            btn_HidingHint.FlatAppearance.BorderSize = 0;
            btn_HidingHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_HidingHint.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_HidingHint.ForeColor = System.Drawing.Color.Black;
            btn_HidingHint.Location = new System.Drawing.Point(12, 672);
            btn_HidingHint.Name = "btn_HidingHint";
            btn_HidingHint.Size = new System.Drawing.Size(117, 65);
            btn_HidingHint.TabIndex = 1;
            btn_HidingHint.Text = "숨겨진 힌트";
            btn_HidingHint.UseVisualStyleBackColor = false;
            btn_HidingHint.Click += btn_HidingHint_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.Transparent;
            btn_Exit.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Exit.BackgroundImage");
            btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Location = new System.Drawing.Point(894, 692);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(50, 50);
            btn_Exit.TabIndex = 2;
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label_Enter
            // 
            label_Enter.AutoSize = true;
            label_Enter.BackColor = System.Drawing.Color.Transparent;
            label_Enter.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label_Enter.ForeColor = System.Drawing.Color.White;
            label_Enter.Location = new System.Drawing.Point(395, 332);
            label_Enter.Name = "label_Enter";
            label_Enter.Size = new System.Drawing.Size(199, 40);
            label_Enter.TabIndex = 4;
            label_Enter.Text = "보스의 콤퓨타";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(348, 385);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new System.Drawing.Size(236, 33);
            textBox1.TabIndex = 5;
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = System.Drawing.Color.Transparent;
            btn_SignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_SignIn.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_SignIn.ForeColor = System.Drawing.Color.White;
            btn_SignIn.Location = new System.Drawing.Point(586, 385);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new System.Drawing.Size(59, 33);
            btn_SignIn.TabIndex = 6;
            btn_SignIn.Text = "Sign In";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(431, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(810, 702);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(35, 35);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(859, 702);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(35, 35);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
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
            lb_minute.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_minute.Location = new System.Drawing.Point(880, 42);
            lb_minute.Name = "lb_minute";
            lb_minute.Size = new System.Drawing.Size(58, 21);
            lb_minute.TabIndex = 9;
            lb_minute.Text = "00 : 00";
            // 
            // Form_MobleEvent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(984, 761);
            Controls.Add(lb_minute);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_SignIn);
            Controls.Add(textBox1);
            Controls.Add(label_Enter);
            Controls.Add(btn_Exit);
            Controls.Add(btn_HidingHint);
            Controls.Add(lblQuestion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form_MobleEvent";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form_MobleEvent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btn_HidingHint;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label_Enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lb_minute;
    }
}