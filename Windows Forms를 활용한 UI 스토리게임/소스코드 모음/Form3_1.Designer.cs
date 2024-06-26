namespace _3_1
{
    partial class Form3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3_1));
            btn3_2 = new System.Windows.Forms.Button();
            btn3_3 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn3_2
            // 
            btn3_2.BackColor = System.Drawing.Color.Transparent;
            btn3_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn3_2.FlatAppearance.BorderSize = 0;
            btn3_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn3_2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn3_2.Image = (System.Drawing.Image)resources.GetObject("btn3_2.Image");
            btn3_2.Location = new System.Drawing.Point(1039, 285);
            btn3_2.Name = "btn3_2";
            btn3_2.Size = new System.Drawing.Size(107, 72);
            btn3_2.TabIndex = 0;
            btn3_2.Text = "(골목길)";
            btn3_2.UseVisualStyleBackColor = false;
            btn3_2.Visible = false;
            btn3_2.Click += btn3_2_Click;
            // 
            // btn3_3
            // 
            btn3_3.BackColor = System.Drawing.Color.Transparent;
            btn3_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btn3_3.FlatAppearance.BorderSize = 0;
            btn3_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn3_3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn3_3.Image = (System.Drawing.Image)resources.GetObject("btn3_3.Image");
            btn3_3.Location = new System.Drawing.Point(70, 285);
            btn3_3.Name = "btn3_3";
            btn3_3.Size = new System.Drawing.Size(90, 65);
            btn3_3.TabIndex = 0;
            btn3_3.Text = "(신호등 )";
            btn3_3.UseVisualStyleBackColor = false;
            btn3_3.Visible = false;
            btn3_3.Click += btn3_3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(35, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 40);
            label1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.BackgroundImage = (System.Drawing.Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(70, 659);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1056, 152);
            panel1.TabIndex = 3;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(957, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(82, 93);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(46, 495);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(258, 170);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Location = new System.Drawing.Point(865, 495);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(258, 170);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form3_1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1184, 861);
            Controls.Add(panel1);
            Controls.Add(btn3_3);
            Controls.Add(btn3_2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form3_1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn3_2;
        private System.Windows.Forms.Button btn3_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
