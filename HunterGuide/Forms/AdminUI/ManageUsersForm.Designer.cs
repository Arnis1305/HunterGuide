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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersForm));
            this.UsersListBox = new System.Windows.Forms.CheckedListBox();
            this.ActivateButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.RejectButton = new MetroFramework.Controls.MetroButton();
            this.SearchButton = new MetroFramework.Controls.MetroButton();
            this.SearchBox = new MetroFramework.Controls.MetroTextBox();
            this.lable = new System.Windows.Forms.Label();
            this.DropButton = new MetroFramework.Controls.MetroButton();
            this.NotActivatedUsersRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.ActivatedUsersRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.UserRolesRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.UserRolesComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ChangeRoleButton = new MetroFramework.Controls.MetroButton();
            this.TargetRoleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetRoleLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsersListBox
            // 
            this.UsersListBox.CheckOnClick = true;
            this.UsersListBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(29, 246);
            this.UsersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(684, 319);
            this.UsersListBox.TabIndex = 0;
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(116, 591);
            this.ActivateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(83, 30);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(631, 591);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(83, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(28, 591);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(83, 30);
            this.RejectButton.TabIndex = 4;
            this.RejectButton.Text = "Reject";
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(543, 210);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(83, 30);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(29, 210);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(507, 30);
            this.SearchBox.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(31, 187);
            this.lable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(340, 19);
            this.lable.TabIndex = 7;
            this.lable.Text = "Search by username, firstname and lastname";
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(631, 210);
            this.DropButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(83, 30);
            this.DropButton.TabIndex = 8;
            this.DropButton.Text = "Drop";
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // NotActivatedUsersRadioButton
            // 
            this.NotActivatedUsersRadioButton.AutoSize = true;
            this.NotActivatedUsersRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotActivatedUsersRadioButton.Location = new System.Drawing.Point(33, 85);
            this.NotActivatedUsersRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotActivatedUsersRadioButton.Name = "NotActivatedUsersRadioButton";
            this.NotActivatedUsersRadioButton.Size = new System.Drawing.Size(186, 17);
            this.NotActivatedUsersRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
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
            this.ActivatedUsersRadioButton.Location = new System.Drawing.Point(265, 85);
            this.ActivatedUsersRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActivatedUsersRadioButton.Name = "ActivatedUsersRadioButton";
            this.ActivatedUsersRadioButton.Size = new System.Drawing.Size(163, 17);
            this.ActivatedUsersRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.ActivatedUsersRadioButton.TabIndex = 10;
            this.ActivatedUsersRadioButton.TabStop = true;
            this.ActivatedUsersRadioButton.Text = "Manage activated users";
            this.ActivatedUsersRadioButton.UseVisualStyleBackColor = true;
            this.ActivatedUsersRadioButton.CheckedChanged += new System.EventHandler(this.ActivatedUsersRadioButton_CheckedChanged);
            // 
            // UserRolesRadioButton
            // 
            this.UserRolesRadioButton.AutoSize = true;
            this.UserRolesRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRolesRadioButton.Location = new System.Drawing.Point(469, 85);
            this.UserRolesRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserRolesRadioButton.Name = "UserRolesRadioButton";
            this.UserRolesRadioButton.Size = new System.Drawing.Size(134, 17);
            this.UserRolesRadioButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.UserRolesRadioButton.TabIndex = 11;
            this.UserRolesRadioButton.TabStop = true;
            this.UserRolesRadioButton.Text = "Manage user roles";
            this.UserRolesRadioButton.UseVisualStyleBackColor = true;
            this.UserRolesRadioButton.CheckedChanged += new System.EventHandler(this.UserRolesRadioButton_CheckedChanged);
            // 
            // UserRolesComboBox
            // 
            this.UserRolesComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRolesComboBox.FormattingEnabled = true;
            this.UserRolesComboBox.ItemHeight = 24;
            this.UserRolesComboBox.Location = new System.Drawing.Point(31, 140);
            this.UserRolesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserRolesComboBox.Name = "UserRolesComboBox";
            this.UserRolesComboBox.Size = new System.Drawing.Size(504, 30);
            this.UserRolesComboBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.UserRolesComboBox.TabIndex = 12;
            this.UserRolesComboBox.SelectedIndexChanged += new System.EventHandler(this.UserRolesComboBox_SelectedIndexChanged);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(28, 591);
            this.ChangeRoleButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(171, 30);
            this.ChangeRoleButton.TabIndex = 13;
            this.ChangeRoleButton.Text = "Add to role...";
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // TargetRoleComboBox
            // 
            this.TargetRoleComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetRoleComboBox.FormattingEnabled = true;
            this.TargetRoleComboBox.ItemHeight = 24;
            this.TargetRoleComboBox.Location = new System.Drawing.Point(543, 140);
            this.TargetRoleComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TargetRoleComboBox.Name = "TargetRoleComboBox";
            this.TargetRoleComboBox.Size = new System.Drawing.Size(169, 30);
            this.TargetRoleComboBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.TargetRoleComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "User role";
            // 
            // TargetRoleLable
            // 
            this.TargetRoleLable.AutoSize = true;
            this.TargetRoleLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetRoleLable.Location = new System.Drawing.Point(545, 117);
            this.TargetRoleLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TargetRoleLable.Name = "TargetRoleLable";
            this.TargetRoleLable.Size = new System.Drawing.Size(85, 19);
            this.TargetRoleLable.TabIndex = 16;
            this.TargetRoleLable.Text = "Target role";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 639);
            this.Controls.Add(this.TargetRoleLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetRoleComboBox);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.UserRolesComboBox);
            this.Controls.Add(this.UserRolesRadioButton);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 639);
            this.MinimumSize = new System.Drawing.Size(744, 639);
            this.Name = "ManageUsersForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Manage users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox UsersListBox;
        private MetroFramework.Controls.MetroButton ActivateButton;
        private MetroFramework.Controls.MetroButton CloseButton;
        private MetroFramework.Controls.MetroButton RejectButton;
        private MetroFramework.Controls.MetroButton SearchButton;
        private MetroFramework.Controls.MetroTextBox SearchBox;
        private System.Windows.Forms.Label lable;
        private MetroFramework.Controls.MetroButton DropButton;
        private MetroFramework.Controls.MetroRadioButton NotActivatedUsersRadioButton;
        private MetroFramework.Controls.MetroRadioButton ActivatedUsersRadioButton;
        private MetroFramework.Controls.MetroRadioButton UserRolesRadioButton;
        private MetroFramework.Controls.MetroComboBox UserRolesComboBox;
        private MetroFramework.Controls.MetroButton ChangeRoleButton;
        private MetroFramework.Controls.MetroComboBox TargetRoleComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TargetRoleLable;
    }
}