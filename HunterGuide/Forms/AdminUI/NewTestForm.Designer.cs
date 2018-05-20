namespace HunterGuide.Forms.AdminUI
{
    partial class NewTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTestForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumQwBox = new System.Windows.Forms.NumericUpDown();
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.ThemeTest = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(363, 303);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(83, 31);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип тестирования:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Тренировочное",
            "Зачётное",
            "Экзаменационное"});
            this.comboBox1.Location = new System.Drawing.Point(258, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тема теста:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название теста:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(258, 182);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(155, 22);
            this.NameBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кол-во вопросов:";
            // 
            // NumQwBox
            // 
            this.NumQwBox.Location = new System.Drawing.Point(258, 232);
            this.NumQwBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumQwBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumQwBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumQwBox.Name = "NumQwBox";
            this.NumQwBox.Size = new System.Drawing.Size(155, 22);
            this.NumQwBox.TabIndex = 15;
            this.NumQwBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Location = new System.Drawing.Point(190, 303);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(77, 29);
            this.CreateTestButton.TabIndex = 16;
            this.CreateTestButton.Text = "Create";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            this.CreateTestButton.Click += new System.EventHandler(this.CreateTestButton_Click);
            // 
            // ThemeTest
            // 
            this.ThemeTest.FormattingEnabled = true;
            this.ThemeTest.Items.AddRange(new object[] {
            "Тема1",
            "Тема2",
            "Тема3",
            "Тема4"});
            this.ThemeTest.Location = new System.Drawing.Point(257, 134);
            this.ThemeTest.Name = "ThemeTest";
            this.ThemeTest.Size = new System.Drawing.Size(155, 24);
            this.ThemeTest.TabIndex = 17;
            // 
            // NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 382);
            this.Controls.Add(this.ThemeTest);
            this.Controls.Add(this.CreateTestButton);
            this.Controls.Add(this.NumQwBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTestForm";
            this.Text = "Новый тест";
            this.Load += new System.EventHandler(this.NewTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown NumQwBox;
        private System.Windows.Forms.Button CreateTestButton;
        private System.Windows.Forms.ComboBox ThemeTest;
    }
}