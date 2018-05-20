using MetroFramework.Controls;

namespace HunterGuide.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.CloseButton = new MetroFramework.Controls.MetroButton();
            this.RegisterButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.lable1 = new MetroFramework.Controls.MetroLabel();
            this.PasswordInput = new MetroFramework.Controls.MetroTextBox();
            this.UsernameInput = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.RepeatPasswordInput = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.LastNameInput = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.FirstNameInput = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(377, 400);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 30);
            this.CloseButton.TabIndex = 16;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(264, 400);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(107, 30);
            this.RegisterButton.TabIndex = 14;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(63, 84);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(73, 20);
            this.lable1.TabIndex = 11;
            this.lable1.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(60, 277);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '●';
            this.PasswordInput.Size = new System.Drawing.Size(424, 25);
            this.PasswordInput.TabIndex = 10;
            this.PasswordInput.UseSystemPasswordChar = true;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(60, 110);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(424, 25);
            this.UsernameInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repeat Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RepeatPasswordInput
            // 
            this.RepeatPasswordInput.Location = new System.Drawing.Point(60, 331);
            this.RepeatPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepeatPasswordInput.Name = "RepeatPasswordInput";
            this.RepeatPasswordInput.PasswordChar = '●';
            this.RepeatPasswordInput.Size = new System.Drawing.Size(424, 25);
            this.RepeatPasswordInput.TabIndex = 17;
            this.RepeatPasswordInput.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastNameInput
            // 
            this.LastNameInput.Location = new System.Drawing.Point(60, 220);
            this.LastNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameInput.Name = "LastNameInput";
            this.LastNameInput.Size = new System.Drawing.Size(424, 25);
            this.LastNameInput.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "First Name";
            // 
            // FirstNameInput
            // 
            this.FirstNameInput.Location = new System.Drawing.Point(60, 166);
            this.FirstNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameInput.Name = "FirstNameInput";
            this.FirstNameInput.Size = new System.Drawing.Size(424, 25);
            this.FirstNameInput.TabIndex = 19;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 457);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RepeatPasswordInput);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(564, 457);
            this.MinimumSize = new System.Drawing.Size(564, 457);
            this.Name = "RegisterForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Regiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroButton CloseButton;
        private MetroButton RegisterButton;
        private MetroLabel label1;
        private MetroLabel lable1;
        private MetroTextBox PasswordInput;
        private MetroTextBox UsernameInput;
        private MetroLabel label3;
        private MetroTextBox RepeatPasswordInput;
        private MetroLabel label4;
        private MetroTextBox LastNameInput;
        private MetroLabel label5;
        private MetroTextBox FirstNameInput;
    }
}