namespace HunterGuide.Forms.AdminUI
{
    partial class ActivateUserForm
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
            this.UsersListBox = new System.Windows.Forms.CheckedListBox();
            this.ActivateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(12, 12);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(634, 344);
            this.UsersListBox.TabIndex = 0;
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(12, 372);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(82, 29);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(564, 372);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(82, 29);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ActivateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.UsersListBox);
            this.Name = "ActivateUserForm";
            this.Text = "ActivateUserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox UsersListBox;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Button CloseButton;
    }
}