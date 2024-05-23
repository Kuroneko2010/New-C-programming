namespace _29.Phonebook_I
{
    partial class Relationship_Adder
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
            this.label1 = new System.Windows.Forms.Label();
            this.RelationshipTextBox = new System.Windows.Forms.RichTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RelationshipErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add your relationship";
            // 
            // RelationshipTextBox
            // 
            this.RelationshipTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationshipTextBox.Location = new System.Drawing.Point(38, 98);
            this.RelationshipTextBox.Name = "RelationshipTextBox";
            this.RelationshipTextBox.Size = new System.Drawing.Size(353, 32);
            this.RelationshipTextBox.TabIndex = 3;
            this.RelationshipTextBox.Text = "";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.AddButton.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(111, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(208, 49);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // RelationshipErrorLabel
            // 
            this.RelationshipErrorLabel.AutoSize = true;
            this.RelationshipErrorLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.RelationshipErrorLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RelationshipErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.RelationshipErrorLabel.Location = new System.Drawing.Point(78, 150);
            this.RelationshipErrorLabel.Name = "RelationshipErrorLabel";
            this.RelationshipErrorLabel.Size = new System.Drawing.Size(273, 18);
            this.RelationshipErrorLabel.TabIndex = 27;
            this.RelationshipErrorLabel.Text = "PLEASE ADD YOUR RELATIONSHIP";
            this.RelationshipErrorLabel.Visible = false;
            // 
            // Relationship_Adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.RelationshipErrorLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RelationshipTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Relationship_Adder";
            this.Size = new System.Drawing.Size(419, 267);
            this.Load += new System.EventHandler(this.Relationship_Adder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RelationshipTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RelationshipErrorLabel;
    }
}
