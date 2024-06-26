namespace Winform_TeamProject
{
    partial class Form_MobleHint1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MobleHint1));
            lbl_HintNumber = new System.Windows.Forms.Label();
            lbl_HintContext = new System.Windows.Forms.Label();
            lbl_Hint = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lbl_HintNumber
            // 
            lbl_HintNumber.AutoSize = true;
            lbl_HintNumber.BackColor = System.Drawing.Color.Transparent;
            lbl_HintNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HintNumber.Location = new System.Drawing.Point(579, 360);
            lbl_HintNumber.Name = "lbl_HintNumber";
            lbl_HintNumber.Size = new System.Drawing.Size(203, 65);
            lbl_HintNumber.TabIndex = 6;
            lbl_HintNumber.Text = "=>    ? ?";
            // 
            // lbl_HintContext
            // 
            lbl_HintContext.AutoSize = true;
            lbl_HintContext.BackColor = System.Drawing.Color.Transparent;
            lbl_HintContext.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_HintContext.Location = new System.Drawing.Point(12, 137);
            lbl_HintContext.Name = "lbl_HintContext";
            lbl_HintContext.Size = new System.Drawing.Size(465, 564);
            lbl_HintContext.TabIndex = 5;
            lbl_HintContext.Text = resources.GetString("lbl_HintContext.Text");
            // 
            // lbl_Hint
            // 
            lbl_Hint.AutoSize = true;
            lbl_Hint.BackColor = System.Drawing.Color.Transparent;
            lbl_Hint.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Hint.Location = new System.Drawing.Point(370, 62);
            lbl_Hint.Name = "lbl_Hint";
            lbl_Hint.Size = new System.Drawing.Size(217, 45);
            lbl_Hint.TabIndex = 7;
            lbl_Hint.Text = "*숨겨진 힌트*";
            // 
            // Form_MobleHint1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(984, 761);
            Controls.Add(lbl_Hint);
            Controls.Add(lbl_HintNumber);
            Controls.Add(lbl_HintContext);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "Form_MobleHint1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_HintNumber;
        private System.Windows.Forms.Label lbl_HintContext;
        private System.Windows.Forms.Label lbl_Hint;
    }
}