namespace _29.Phonebook_I
{
    partial class User_Interface
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
            this.components = new System.ComponentModel.Container();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberStorerLabel = new System.Windows.Forms.Label();
            this.MoreButton = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(10, 2);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(151, 31);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "(Username)";
            // 
            // PhoneNumberStorerLabel
            // 
            this.PhoneNumberStorerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneNumberStorerLabel.AutoSize = true;
            this.PhoneNumberStorerLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberStorerLabel.Location = new System.Drawing.Point(123, 7);
            this.PhoneNumberStorerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PhoneNumberStorerLabel.Name = "PhoneNumberStorerLabel";
            this.PhoneNumberStorerLabel.Size = new System.Drawing.Size(153, 23);
            this.PhoneNumberStorerLabel.TabIndex = 2;
            this.PhoneNumberStorerLabel.Text = "(Phone Number)";
            this.PhoneNumberStorerLabel.Visible = false;
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MoreButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MoreButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreButton.Location = new System.Drawing.Point(279, -1);
            this.MoreButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(55, 28);
            this.MoreButton.TabIndex = 1;
            this.MoreButton.Text = "More";
            this.MoreButton.UseVisualStyleBackColor = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.deleteToolStripMenuItem.Text = "Delete profile";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // viewProfileToolStripMenuItem
            // 
            this.viewProfileToolStripMenuItem.Name = "viewProfileToolStripMenuItem";
            this.viewProfileToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.viewProfileToolStripMenuItem.Text = "View profile";
            this.viewProfileToolStripMenuItem.Click += new System.EventHandler(this.viewProfileToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.viewProfileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 68);
            // 
            // User_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PhoneNumberStorerLabel);
            this.Controls.Add(this.MoreButton);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "User_Interface";
            this.Size = new System.Drawing.Size(352, 27);
            this.Load += new System.EventHandler(this.User_Interface_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneNumberStorerLabel;
        private System.Windows.Forms.Button MoreButton;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProfileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
