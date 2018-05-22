namespace HunterGuide.Forms
{
    using MetroFramework.Controls;

    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.UsernameInput = new MetroFramework.Controls.MetroTextBox();
            this.PasswordInput = new MetroFramework.Controls.MetroTextBox();
            this.lable1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.RegisterButton = new MetroFramework.Controls.MetroButton();
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(52, 113);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(424, 25);
            this.UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(52, 166);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '●';
            this.PasswordInput.Size = new System.Drawing.Size(424, 25);
            this.PasswordInput.TabIndex = 1;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(52, 87);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(73, 20);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(257, 234);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(107, 30);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(52, 234);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(107, 30);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(369, 234);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 30);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 290);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 290);
            this.MinimumSize = new System.Drawing.Size(525, 290);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroTextBox UsernameInput;
        private MetroTextBox PasswordInput;
        private MetroLabel lable1;
        private MetroLabel label1;
        private MetroButton LoginButton;
        private MetroButton RegisterButton;
        private MetroButton CloseButton;
    }
}