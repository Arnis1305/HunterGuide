namespace HunterGuide.Forms.ClientUI
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TestTypesComboBox = new System.Windows.Forms.ComboBox();
            this.TestTopicsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TestNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(383, 223);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(64, 29);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип тестирования";
            // 
            // TestTypesComboBox
            // 
            this.TestTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestTypesComboBox.FormattingEnabled = true;
            this.TestTypesComboBox.Items.AddRange(new object[] {
            "Тренировочное",
            "Зачётное",
            "Экзаменационное"});
            this.TestTypesComboBox.Location = new System.Drawing.Point(127, 91);
            this.TestTypesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestTypesComboBox.Name = "TestTypesComboBox";
            this.TestTypesComboBox.Size = new System.Drawing.Size(298, 21);
            this.TestTypesComboBox.TabIndex = 4;
            this.TestTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.TestTypesComboBox_SelectedIndexChanged);
            // 
            // TestTopicsComboBox
            // 
            this.TestTopicsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestTopicsComboBox.FormattingEnabled = true;
            this.TestTopicsComboBox.Items.AddRange(new object[] {
            "Тема1",
            "Тема2",
            "Тема3",
            "Тема4"});
            this.TestTopicsComboBox.Location = new System.Drawing.Point(127, 125);
            this.TestTopicsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestTopicsComboBox.Name = "TestTopicsComboBox";
            this.TestTopicsComboBox.Size = new System.Drawing.Size(298, 21);
            this.TestTopicsComboBox.TabIndex = 7;
            this.TestTopicsComboBox.SelectedIndexChanged += new System.EventHandler(this.TestTopicsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тема теста";
            // 
            // TestNamesComboBox
            // 
            this.TestNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestNamesComboBox.FormattingEnabled = true;
            this.TestNamesComboBox.Items.AddRange(new object[] {
            "Тренировочное",
            "Зачётное",
            "Экзаменационное"});
            this.TestNamesComboBox.Location = new System.Drawing.Point(127, 156);
            this.TestNamesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestNamesComboBox.Name = "TestNamesComboBox";
            this.TestNamesComboBox.Size = new System.Drawing.Size(298, 21);
            this.TestNamesComboBox.TabIndex = 9;
            this.TestNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.TestNamesComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название теста";
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(143, 223);
            this.StartTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(116, 28);
            this.StartTestButton.TabIndex = 12;
            this.StartTestButton.Text = "Начать";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(263, 223);
            this.ResultsButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(116, 28);
            this.ResultsButton.TabIndex = 13;
            this.ResultsButton.Text = "Мои результаты";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 270);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TestNamesComboBox);
            this.Controls.Add(this.TestTopicsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestTypesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserMainForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Hunter Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TestTypesComboBox;
        private System.Windows.Forms.ComboBox TestTopicsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TestNamesComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button ResultsButton;
    }
}