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
            this.UsersListBox.Location = new System.Drawing.Point(22, 200);
            this.UsersListBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(514, 276);
            this.UsersListBox.TabIndex = 0;
            // 
            // ActivateButton
            // 
            this.ActivateButton.Location = new System.Drawing.Point(87, 480);
            this.ActivateButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.Size = new System.Drawing.Size(62, 24);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Activate";
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(473, 480);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(62, 24);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RejectButton
            // 
            this.RejectButton.Location = new System.Drawing.Point(21, 480);
            this.RejectButton.Margin = new System.Windows.Forms.Padding(2);
            this.RejectButton.Name = "RejectButton";
            this.RejectButton.Size = new System.Drawing.Size(62, 24);
            this.RejectButton.TabIndex = 4;
            this.RejectButton.Text = "Reject";
            this.RejectButton.Click += new System.EventHandler(this.RejectButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(407, 171);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(62, 24);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(22, 171);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(380, 24);
            this.SearchBox.TabIndex = 6;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lable.Location = new System.Drawing.Point(23, 152);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(271, 16);
            this.lable.TabIndex = 7;
            this.lable.Text = "Search by username, firstname and lastname";
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(473, 171);
            this.DropButton.Margin = new System.Windows.Forms.Padding(2);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(62, 24);
            this.DropButton.TabIndex = 8;
            this.DropButton.Text = "Drop";
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // NotActivatedUsersRadioButton
            // 
            this.NotActivatedUsersRadioButton.AutoSize = true;
            this.NotActivatedUsersRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotActivatedUsersRadioButton.Location = new System.Drawing.Point(25, 69);
            this.NotActivatedUsersRadioButton.Name = "NotActivatedUsersRadioButton";
            this.NotActivatedUsersRadioButton.Size = new System.Drawing.Size(168, 15);
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
            this.ActivatedUsersRadioButton.Location = new System.Drawing.Point(199, 69);
            this.ActivatedUsersRadioButton.Name = "ActivatedUsersRadioButton";
            this.ActivatedUsersRadioButton.Size = new System.Drawing.Size(147, 15);
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
            this.UserRolesRadioButton.Location = new System.Drawing.Point(352, 69);
            this.UserRolesRadioButton.Name = "UserRolesRadioButton";
            this.UserRolesRadioButton.Size = new System.Drawing.Size(119, 15);
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
            this.UserRolesComboBox.ItemHeight = 23;
            this.UserRolesComboBox.Location = new System.Drawing.Point(23, 114);
            this.UserRolesComboBox.Name = "UserRolesComboBox";
            this.UserRolesComboBox.Size = new System.Drawing.Size(379, 29);
            this.UserRolesComboBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.UserRolesComboBox.TabIndex = 12;
            this.UserRolesComboBox.SelectedIndexChanged += new System.EventHandler(this.UserRolesComboBox_SelectedIndexChanged);
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Location = new System.Drawing.Point(21, 480);
            this.ChangeRoleButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(128, 24);
            this.ChangeRoleButton.TabIndex = 13;
            this.ChangeRoleButton.Text = "Add to role...";
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // TargetRoleComboBox
            // 
            this.TargetRoleComboBox.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetRoleComboBox.FormattingEnabled = true;
            this.TargetRoleComboBox.ItemHeight = 23;
            this.TargetRoleComboBox.Location = new System.Drawing.Point(407, 114);
            this.TargetRoleComboBox.Name = "TargetRoleComboBox";
            this.TargetRoleComboBox.Size = new System.Drawing.Size(128, 29);
            this.TargetRoleComboBox.Style = MetroFramework.MetroColorStyle.Orange;
            this.TargetRoleComboBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "User role";
            // 
            // TargetRoleLable
            // 
            this.TargetRoleLable.AutoSize = true;
            this.TargetRoleLable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TargetRoleLable.Location = new System.Drawing.Point(409, 95);
            this.TargetRoleLable.Name = "TargetRoleLable";
            this.TargetRoleLable.Size = new System.Drawing.Size(68, 16);
            this.TargetRoleLable.TabIndex = 16;
            this.TargetRoleLable.Text = "Target role";
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 519);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(558, 519);
            this.MinimumSize = new System.Drawing.Size(558, 519);
            this.Name = "ManageUsersForm";
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