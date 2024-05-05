namespace _29.Phonebook_I
{
    partial class Profile_Viewer
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
            this.GetBackButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.RelationshipLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PhoneNumberStorerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetBackButton
            // 
            this.GetBackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.GetBackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetBackButton.Location = new System.Drawing.Point(20, 16);
            this.GetBackButton.Name = "GetBackButton";
            this.GetBackButton.Size = new System.Drawing.Size(143, 60);
            this.GetBackButton.TabIndex = 0;
            this.GetBackButton.Text = "<= Get back";
            this.GetBackButton.UseVisualStyleBackColor = false;
            this.GetBackButton.Click += new System.EventHandler(this.GetBackButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(97, 98);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(228, 45);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "(Username)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Relationship:  ";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(275, 187);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(158, 27);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "(0123456789)\r\n";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(199, 259);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(209, 27);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "(Hồ Chí Minh City)\r\n";
            // 
            // RelationshipLabel
            // 
            this.RelationshipLabel.AutoSize = true;
            this.RelationshipLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationshipLabel.Location = new System.Drawing.Point(250, 331);
            this.RelationshipLabel.Name = "RelationshipLabel";
            this.RelationshipLabel.Size = new System.Drawing.Size(137, 27);
            this.RelationshipLabel.TabIndex = 7;
            this.RelationshipLabel.Text = "(Colleague)";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EditButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(104, 383);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(201, 47);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit profile";
            this.EditButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(442, 383);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(201, 47);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete profile";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PhoneNumberStorerLabel
            // 
            this.PhoneNumberStorerLabel.AutoSize = true;
            this.PhoneNumberStorerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberStorerLabel.Location = new System.Drawing.Point(321, 110);
            this.PhoneNumberStorerLabel.Name = "PhoneNumberStorerLabel";
            this.PhoneNumberStorerLabel.Size = new System.Drawing.Size(158, 27);
            this.PhoneNumberStorerLabel.TabIndex = 10;
            this.PhoneNumberStorerLabel.Text = "(0123456789)\r\n";
            this.PhoneNumberStorerLabel.Visible = false;
            // 
            // Profile_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(742, 462);
            this.Controls.Add(this.PhoneNumberStorerLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.RelationshipLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GetBackButton);
            this.Name = "Profile_Viewer";
            this.Load += new System.EventHandler(this.Profile_Viewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetBackButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label RelationshipLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label PhoneNumberStorerLabel;
    }
}
