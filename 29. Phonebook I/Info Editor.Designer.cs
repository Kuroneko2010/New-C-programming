namespace _29.Phonebook_I
{
    partial class Info_Editor
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
            this.InfoEditorLabel = new System.Windows.Forms.Label();
            this.NameSignLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.RichTextBox();
            this.NameErrorLabel = new System.Windows.Forms.Label();
            this.PhoneNumberSignLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.PhoneNumberErrorLabel = new System.Windows.Forms.Label();
            this.AddressSignLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.RichTextBox();
            this.RelationshipSignLabel = new System.Windows.Forms.Label();
            this.FamilyButton = new System.Windows.Forms.Button();
            this.FriendButton = new System.Windows.Forms.Button();
            this.ClassmateButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.ColleagueButton = new System.Windows.Forms.Button();
            this.TeacherButton = new System.Windows.Forms.Button();
            this.AssistantButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RelationshipErrorLabel = new System.Windows.Forms.Label();
            this.PhoneNumberInvalidError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InfoEditorLabel
            // 
            this.InfoEditorLabel.AutoSize = true;
            this.InfoEditorLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoEditorLabel.Location = new System.Drawing.Point(211, 18);
            this.InfoEditorLabel.Name = "InfoEditorLabel";
            this.InfoEditorLabel.Size = new System.Drawing.Size(238, 36);
            this.InfoEditorLabel.TabIndex = 1;
            this.InfoEditorLabel.Text = "Edit Information";
            // 
            // NameSignLabel
            // 
            this.NameSignLabel.AutoSize = true;
            this.NameSignLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSignLabel.Location = new System.Drawing.Point(43, 55);
            this.NameSignLabel.Name = "NameSignLabel";
            this.NameSignLabel.Size = new System.Drawing.Size(67, 23);
            this.NameSignLabel.TabIndex = 2;
            this.NameSignLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(47, 81);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(559, 29);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.Text = "";
            // 
            // NameErrorLabel
            // 
            this.NameErrorLabel.AutoSize = true;
            this.NameErrorLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLabel.Location = new System.Drawing.Point(44, 113);
            this.NameErrorLabel.Name = "NameErrorLabel";
            this.NameErrorLabel.Size = new System.Drawing.Size(374, 18);
            this.NameErrorLabel.TabIndex = 23;
            this.NameErrorLabel.Text = "You haven\'t added the username yet, please try again";
            this.NameErrorLabel.Visible = false;
            // 
            // PhoneNumberSignLabel
            // 
            this.PhoneNumberSignLabel.AutoSize = true;
            this.PhoneNumberSignLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberSignLabel.Location = new System.Drawing.Point(43, 145);
            this.PhoneNumberSignLabel.Name = "PhoneNumberSignLabel";
            this.PhoneNumberSignLabel.Size = new System.Drawing.Size(142, 23);
            this.PhoneNumberSignLabel.TabIndex = 24;
            this.PhoneNumberSignLabel.Text = "Phone number:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(47, 171);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(559, 29);
            this.PhoneNumberTextBox.TabIndex = 25;
            this.PhoneNumberTextBox.Text = "";
            // 
            // PhoneNumberErrorLabel
            // 
            this.PhoneNumberErrorLabel.AutoSize = true;
            this.PhoneNumberErrorLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.PhoneNumberErrorLabel.Location = new System.Drawing.Point(44, 205);
            this.PhoneNumberErrorLabel.Name = "PhoneNumberErrorLabel";
            this.PhoneNumberErrorLabel.Size = new System.Drawing.Size(338, 18);
            this.PhoneNumberErrorLabel.TabIndex = 26;
            this.PhoneNumberErrorLabel.Text = "The phone number has existed, please try again";
            this.PhoneNumberErrorLabel.Visible = false;
            // 
            // AddressSignLabel
            // 
            this.AddressSignLabel.AutoSize = true;
            this.AddressSignLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressSignLabel.Location = new System.Drawing.Point(43, 240);
            this.AddressSignLabel.Name = "AddressSignLabel";
            this.AddressSignLabel.Size = new System.Drawing.Size(89, 23);
            this.AddressSignLabel.TabIndex = 27;
            this.AddressSignLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(47, 266);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(559, 29);
            this.AddressTextBox.TabIndex = 28;
            this.AddressTextBox.Text = "";
            // 
            // RelationshipSignLabel
            // 
            this.RelationshipSignLabel.AutoSize = true;
            this.RelationshipSignLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationshipSignLabel.Location = new System.Drawing.Point(43, 322);
            this.RelationshipSignLabel.Name = "RelationshipSignLabel";
            this.RelationshipSignLabel.Size = new System.Drawing.Size(122, 23);
            this.RelationshipSignLabel.TabIndex = 29;
            this.RelationshipSignLabel.Text = "Relationship:";
            // 
            // FamilyButton
            // 
            this.FamilyButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyButton.Location = new System.Drawing.Point(47, 348);
            this.FamilyButton.Name = "FamilyButton";
            this.FamilyButton.Size = new System.Drawing.Size(99, 54);
            this.FamilyButton.TabIndex = 30;
            this.FamilyButton.Text = "Family";
            this.FamilyButton.UseVisualStyleBackColor = true;
            this.FamilyButton.Click += new System.EventHandler(this.FamilyButton_Click);
            // 
            // FriendButton
            // 
            this.FriendButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendButton.Location = new System.Drawing.Point(200, 348);
            this.FriendButton.Name = "FriendButton";
            this.FriendButton.Size = new System.Drawing.Size(99, 54);
            this.FriendButton.TabIndex = 31;
            this.FriendButton.Text = "Friend";
            this.FriendButton.UseVisualStyleBackColor = true;
            this.FriendButton.Click += new System.EventHandler(this.FriendButton_Click);
            // 
            // ClassmateButton
            // 
            this.ClassmateButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassmateButton.Location = new System.Drawing.Point(350, 348);
            this.ClassmateButton.Name = "ClassmateButton";
            this.ClassmateButton.Size = new System.Drawing.Size(99, 54);
            this.ClassmateButton.TabIndex = 32;
            this.ClassmateButton.Text = "Classmate";
            this.ClassmateButton.UseVisualStyleBackColor = true;
            this.ClassmateButton.Click += new System.EventHandler(this.ClassmateButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerButton.Location = new System.Drawing.Point(507, 348);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(99, 54);
            this.CustomerButton.TabIndex = 33;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // ColleagueButton
            // 
            this.ColleagueButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColleagueButton.Location = new System.Drawing.Point(47, 426);
            this.ColleagueButton.Name = "ColleagueButton";
            this.ColleagueButton.Size = new System.Drawing.Size(99, 54);
            this.ColleagueButton.TabIndex = 34;
            this.ColleagueButton.Text = "Colleague";
            this.ColleagueButton.UseVisualStyleBackColor = true;
            this.ColleagueButton.Click += new System.EventHandler(this.ColleagueButton_Click);
            // 
            // TeacherButton
            // 
            this.TeacherButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherButton.Location = new System.Drawing.Point(200, 426);
            this.TeacherButton.Name = "TeacherButton";
            this.TeacherButton.Size = new System.Drawing.Size(99, 54);
            this.TeacherButton.TabIndex = 35;
            this.TeacherButton.Text = "Teacher";
            this.TeacherButton.UseVisualStyleBackColor = true;
            this.TeacherButton.Click += new System.EventHandler(this.TeacherButton_Click);
            // 
            // AssistantButton
            // 
            this.AssistantButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssistantButton.Location = new System.Drawing.Point(350, 426);
            this.AssistantButton.Name = "AssistantButton";
            this.AssistantButton.Size = new System.Drawing.Size(99, 54);
            this.AssistantButton.TabIndex = 36;
            this.AssistantButton.Text = "Assistant";
            this.AssistantButton.UseVisualStyleBackColor = true;
            this.AssistantButton.Click += new System.EventHandler(this.AssistantButton_Click);
            // 
            // OtherButton
            // 
            this.OtherButton.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherButton.Location = new System.Drawing.Point(507, 426);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(99, 54);
            this.OtherButton.TabIndex = 37;
            this.OtherButton.Text = "Other";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EditButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(233, 522);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(198, 53);
            this.EditButton.TabIndex = 38;
            this.EditButton.Text = "Edit/Save";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RelationshipErrorLabel
            // 
            this.RelationshipErrorLabel.AutoSize = true;
            this.RelationshipErrorLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RelationshipErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationshipErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RelationshipErrorLabel.Location = new System.Drawing.Point(138, 492);
            this.RelationshipErrorLabel.Name = "RelationshipErrorLabel";
            this.RelationshipErrorLabel.Size = new System.Drawing.Size(390, 18);
            this.RelationshipErrorLabel.TabIndex = 39;
            this.RelationshipErrorLabel.Text = "You haven\'t chosen the relationship yet, please try again";
            this.RelationshipErrorLabel.Visible = false;
            // 
            // PhoneNumberInvalidError
            // 
            this.PhoneNumberInvalidError.AutoSize = true;
            this.PhoneNumberInvalidError.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PhoneNumberInvalidError.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberInvalidError.ForeColor = System.Drawing.Color.Red;
            this.PhoneNumberInvalidError.Location = new System.Drawing.Point(44, 205);
            this.PhoneNumberInvalidError.Name = "PhoneNumberInvalidError";
            this.PhoneNumberInvalidError.Size = new System.Drawing.Size(271, 18);
            this.PhoneNumberInvalidError.TabIndex = 40;
            this.PhoneNumberInvalidError.Text = "Invalid phone number, please try again";
            this.PhoneNumberInvalidError.Visible = false;
            // 
            // Info_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 594);
            this.Controls.Add(this.PhoneNumberInvalidError);
            this.Controls.Add(this.RelationshipErrorLabel);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.AssistantButton);
            this.Controls.Add(this.TeacherButton);
            this.Controls.Add(this.ColleagueButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.ClassmateButton);
            this.Controls.Add(this.FriendButton);
            this.Controls.Add(this.FamilyButton);
            this.Controls.Add(this.RelationshipSignLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressSignLabel);
            this.Controls.Add(this.PhoneNumberErrorLabel);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.PhoneNumberSignLabel);
            this.Controls.Add(this.NameErrorLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameSignLabel);
            this.Controls.Add(this.InfoEditorLabel);
            this.Name = "Info_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Info_Editor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoEditorLabel;
        private System.Windows.Forms.Label NameSignLabel;
        private System.Windows.Forms.RichTextBox NameTextBox;
        private System.Windows.Forms.Label NameErrorLabel;
        private System.Windows.Forms.Label PhoneNumberSignLabel;
        private System.Windows.Forms.RichTextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberErrorLabel;
        private System.Windows.Forms.Label AddressSignLabel;
        private System.Windows.Forms.RichTextBox AddressTextBox;
        private System.Windows.Forms.Label RelationshipSignLabel;
        private System.Windows.Forms.Button FamilyButton;
        private System.Windows.Forms.Button FriendButton;
        private System.Windows.Forms.Button ClassmateButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button ColleagueButton;
        private System.Windows.Forms.Button TeacherButton;
        private System.Windows.Forms.Button AssistantButton;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label RelationshipErrorLabel;
        private System.Windows.Forms.Label PhoneNumberInvalidError;
    }
}
