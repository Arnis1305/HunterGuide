namespace HunterGuide.Forms.AdminUI
{
    partial class ManageUsersForm
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
            this.RejectButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.DropButton = new System.Windows.Forms.Button();
            this.NotActivatedUsersRadioButton = new System.Windows.Forms.RadioButton();
            this.ActivatedUsersRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(7, 86);
            this.UsersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(476, 276);
            this.UsersListBox.TabIndex = 0;
            // 
            // ActivateButton
            // 
            this.ActivateButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivateButton.Location = new System.Drawing.Point(73, 377);
            this.ActivateButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(62, 24);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.UseVisualStyleBackColor = true;
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(421, 377);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(62, 24);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RejectButton.Location = new System.Drawing.Point(7, 377);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(2);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(62, 24);
            this.RejectButton.TabIndex = 4;
            this.RejectButton.Text = "Reject";
            this.RejectButton.UseVisualStyleBackColor = true;
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(354, 57);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 24);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(7, 61);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(342, 20);
            this.SearchBox.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(12, 44);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(226, 14);
            this.lable.TabIndex = 7;
            this.lable.Text = "Search by username, firstname and lastname";
            // 
            // DropButton
            // 
            this.DropButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DropButton.Location = new System.Drawing.Point(421, 57);
            this.DropButton.Margin = new System.Windows.Forms.Padding(2);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(62, 24);
            this.DropButton.TabIndex = 8;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // NotActivatedUsersRadioButton
            // 
            this.NotActivatedUsersRadioButton.AutoSize = true;
            this.NotActivatedUsersRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotActivatedUsersRadioButton.Location = new System.Drawing.Point(7, 12);
            this.NotActivatedUsersRadioButton.Name = "NotActivatedUsersRadioButton";
            this.NotActivatedUsersRadioButton.Size = new System.Drawing.Size(159, 18);
            this.NotActivatedUsersRadioButton.TabIndex = 9;
            this.NotActivatedUsersRadioButton.TabStop = true;
            this.NotActivatedUsersRadioButton.Text = "Manage not activated users";
            this.NotActivatedUsersRadioButton.UseVisualStyleBackColor = true;
            this.NotActivatedUsersRadioButton.CheckedChanged += new System.EventHandler(this.NotActivatedUsersRadioButton_CheckedChanged);
            // 
            // ActivatedUsersRadioButton
            // 
            this.ActivatedUsersRadioButton.AutoSize = true;
            this.ActivatedUsersRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActivatedUsersRadioButton.Location = new System.Drawing.Point(172, 12);
            this.ActivatedUsersRadioButton.Name = "ActivatedUsersRadioButton";
            this.ActivatedUsersRadioButton.Size = new System.Drawing.Size(141, 18);
            this.ActivatedUsersRadioButton.TabIndex = 10;
            this.ActivatedUsersRadioButton.TabStop = true;
            this.ActivatedUsersRadioButton.Text = "Manage activated users";
            this.ActivatedUsersRadioButton.UseVisualStyleBackColor = true;
            this.ActivatedUsersRadioButton.CheckedChanged += new System.EventHandler(this.ActivatedUsersRadioButton_CheckedChanged);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 411);
            this.Controls.Add(this.ActivatedUsersRadioButton);
            this.Controls.Add(this.NotActivatedUsersRadioButton);
            this.Controls.Add(this.DropButton);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.RejectButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.UsersListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(510, 450);
            this.MinimumSize = new System.Drawing.Size(510, 450);
            this.Name = "ManageUsersForm";
            this.Text = "Manage not activated users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox UsersListBox;
        private System.Windows.Forms.Button ActivateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RejectButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button DropButton;
        private System.Windows.Forms.RadioButton NotActivatedUsersRadioButton;
        private System.Windows.Forms.RadioButton ActivatedUsersRadioButton;
    }
}