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
            this.TestTypesComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NumQwBox = new System.Windows.Forms.NumericUpDown();
            this.CreateTestButton = new System.Windows.Forms.Button();
            this.TestTopicsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(297, 267);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(74, 25);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип тестирования:";
            // 
            // TestTypesComboBox
            // 
            this.TestTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestTypesComboBox.FormattingEnabled = true;
            this.TestTypesComboBox.Location = new System.Drawing.Point(188, 87);
            this.TestTypesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestTypesComboBox.Name = "TestTypesComboBox";
            this.TestTypesComboBox.Size = new System.Drawing.Size(162, 21);
            this.TestTypesComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тема теста:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название теста:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(188, 166);
            this.NameBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(162, 20);
            this.NameBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кол-во вопросов:";
            // 
            // NumQwBox
            // 
            this.NumQwBox.Location = new System.Drawing.Point(188, 206);
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
            this.NumQwBox.Size = new System.Drawing.Size(161, 20);
            this.NumQwBox.TabIndex = 15;
            this.NumQwBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateTestButton
            // 
            this.CreateTestButton.Location = new System.Drawing.Point(219, 267);
            this.CreateTestButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateTestButton.Name = "CreateTestButton";
            this.CreateTestButton.Size = new System.Drawing.Size(74, 25);
            this.CreateTestButton.TabIndex = 16;
            this.CreateTestButton.Text = "Create";
            this.CreateTestButton.UseVisualStyleBackColor = true;
            this.CreateTestButton.Click += new System.EventHandler(this.CreateTestButton_Click);
            // 
            // TestTopicsComboBox
            // 
            this.TestTopicsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestTopicsComboBox.FormattingEnabled = true;
            this.TestTopicsComboBox.Location = new System.Drawing.Point(187, 127);
            this.TestTopicsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestTopicsComboBox.Name = "TestTopicsComboBox";
            this.TestTopicsComboBox.Size = new System.Drawing.Size(162, 21);
            this.TestTopicsComboBox.TabIndex = 17;
            // 
            // NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.TestTopicsComboBox);
            this.Controls.Add(this.CreateTestButton);
            this.Controls.Add(this.NumQwBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestTypesComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(388, 310);
            this.MinimumSize = new System.Drawing.Size(388, 310);
            this.Name = "NewTestForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Новый тест";
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TestTypesComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown NumQwBox;
        private System.Windows.Forms.Button CreateTestButton;
        private System.Windows.Forms.ComboBox TestTopicsComboBox;
    }
}