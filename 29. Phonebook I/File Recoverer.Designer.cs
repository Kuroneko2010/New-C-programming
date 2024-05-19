namespace _29.Phonebook_I
{
    partial class File_Recoverer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlLabel = new System.Windows.Forms.Label();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.URLTextBox = new System.Windows.Forms.RichTextBox();
            this.RecoverButton = new System.Windows.Forms.Button();
            this.InvalidErrorLabel = new System.Windows.Forms.Label();
            this.NullFileErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlLabel.Location = new System.Drawing.Point(33, 44);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(0, 36);
            this.UrlLabel.TabIndex = 0;
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFileButton.Location = new System.Drawing.Point(152, 41);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(151, 49);
            this.ChooseFileButton.TabIndex = 1;
            this.ChooseFileButton.Text = "Choose a file";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // URLTextBox
            // 
            this.URLTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URLTextBox.Location = new System.Drawing.Point(18, 112);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(425, 32);
            this.URLTextBox.TabIndex = 2;
            this.URLTextBox.Text = "";
            // 
            // RecoverButton
            // 
            this.RecoverButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RecoverButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverButton.Location = new System.Drawing.Point(126, 195);
            this.RecoverButton.Name = "RecoverButton";
            this.RecoverButton.Size = new System.Drawing.Size(208, 49);
            this.RecoverButton.TabIndex = 3;
            this.RecoverButton.Text = "RECOVER";
            this.RecoverButton.UseVisualStyleBackColor = false;
            this.RecoverButton.Click += new System.EventHandler(this.RecoverButton_Click);
            // 
            // InvalidErrorLabel
            // 
            this.InvalidErrorLabel.AutoSize = true;
            this.InvalidErrorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.InvalidErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidErrorLabel.Location = new System.Drawing.Point(97, 160);
            this.InvalidErrorLabel.Name = "InvalidErrorLabel";
            this.InvalidErrorLabel.Size = new System.Drawing.Size(260, 18);
            this.InvalidErrorLabel.TabIndex = 25;
            this.InvalidErrorLabel.Text = "INVALID FILE, PLEASE TRY AGAIN";
            this.InvalidErrorLabel.Visible = false;
            // 
            // NullFileErrorLabel
            // 
            this.NullFileErrorLabel.AutoSize = true;
            this.NullFileErrorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.NullFileErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NullFileErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NullFileErrorLabel.Location = new System.Drawing.Point(97, 160);
            this.NullFileErrorLabel.Name = "NullFileErrorLabel";
            this.NullFileErrorLabel.Size = new System.Drawing.Size(259, 18);
            this.NullFileErrorLabel.TabIndex = 26;
            this.NullFileErrorLabel.Text = "YOU MUST CHOOSE A FILE FIRST";
            this.NullFileErrorLabel.Visible = false;
            // 
            // File_Recoverer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(461, 266);
            this.Controls.Add(this.NullFileErrorLabel);
            this.Controls.Add(this.InvalidErrorLabel);
            this.Controls.Add(this.RecoverButton);
            this.Controls.Add(this.URLTextBox);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.UrlLabel);
            this.Name = "File_Recoverer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.File_Recoverer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.RichTextBox URLTextBox;
        private System.Windows.Forms.Button RecoverButton;
        private System.Windows.Forms.Label InvalidErrorLabel;
        private System.Windows.Forms.Label NullFileErrorLabel;
    }
}
