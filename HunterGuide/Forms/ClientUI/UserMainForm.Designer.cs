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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TestCategory = new System.Windows.Forms.ComboBox();
            this.ThemeTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.ResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип тестирования";
            // 
            // TestCategory
            // 
            this.TestCategory.FormattingEnabled = true;
            this.TestCategory.Items.AddRange(new object[] {
            "Тренировочное",
            "Зачётное",
            "Экзаменационное"});
            this.TestCategory.Location = new System.Drawing.Point(184, 86);
            this.TestCategory.Name = "TestCategory";
            this.TestCategory.Size = new System.Drawing.Size(155, 24);
            this.TestCategory.TabIndex = 4;
            // 
            // ThemeTest
            // 
            this.ThemeTest.FormattingEnabled = true;
            this.ThemeTest.Items.AddRange(new object[] {
            "Тема1",
            "Тема2",
            "Тема3",
            "Тема4"});
            this.ThemeTest.Location = new System.Drawing.Point(184, 127);
            this.ThemeTest.Name = "ThemeTest";
            this.ThemeTest.Size = new System.Drawing.Size(155, 24);
            this.ThemeTest.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Тема теста";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "блокировать, если экзамен";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тренировочное",
            "Зачётное",
            "Экзаменационное"});
            this.comboBox1.Location = new System.Drawing.Point(184, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название теста";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "блокировать, если экзамен / зачёт";
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(23, 216);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(155, 30);
            this.StartTestButton.TabIndex = 12;
            this.StartTestButton.Text = "Начать";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // ResultsButton
            // 
            this.ResultsButton.Location = new System.Drawing.Point(206, 216);
            this.ResultsButton.Name = "ResultsButton";
            this.ResultsButton.Size = new System.Drawing.Size(155, 34);
            this.ResultsButton.TabIndex = 13;
            this.ResultsButton.Text = "Мои результаты";
            this.ResultsButton.UseVisualStyleBackColor = true;
            this.ResultsButton.Click += new System.EventHandler(this.ResultsButton_Click);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 381);
            this.Controls.Add(this.ResultsButton);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThemeTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UserMainForm";
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TestCategory;
        private System.Windows.Forms.ComboBox ThemeTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Button ResultsButton;
    }
}