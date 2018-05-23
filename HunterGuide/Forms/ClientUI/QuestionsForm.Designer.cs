namespace HunterGuide.Forms.ClientUI
{
    partial class QuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.QuizHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Answ1 = new System.Windows.Forms.RadioButton();
            this.Answ2 = new System.Windows.Forms.RadioButton();
            this.Answ3 = new System.Windows.Forms.RadioButton();
            this.Answ4 = new System.Windows.Forms.RadioButton();
            this.NextQwButton = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вопрос:";
            // 
            // QuizHeader
            // 
            this.QuizHeader.Location = new System.Drawing.Point(17, 80);
            this.QuizHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuizHeader.Name = "QuizHeader";
            this.QuizHeader.Size = new System.Drawing.Size(569, 80);
            this.QuizHeader.TabIndex = 1;
            this.QuizHeader.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Варианты ответа:";
            // 
            // Answ1
            // 
            this.Answ1.AutoSize = true;
            this.Answ1.Checked = true;
            this.Answ1.Location = new System.Drawing.Point(20, 213);
            this.Answ1.Margin = new System.Windows.Forms.Padding(2);
            this.Answ1.Name = "Answ1";
            this.Answ1.Size = new System.Drawing.Size(57, 17);
            this.Answ1.TabIndex = 3;
            this.Answ1.TabStop = true;
            this.Answ1.Text = "Answ1";
            this.Answ1.UseVisualStyleBackColor = true;
            // 
            // Answ2
            // 
            this.Answ2.AutoSize = true;
            this.Answ2.Location = new System.Drawing.Point(20, 249);
            this.Answ2.Margin = new System.Windows.Forms.Padding(2);
            this.Answ2.Name = "Answ2";
            this.Answ2.Size = new System.Drawing.Size(57, 17);
            this.Answ2.TabIndex = 4;
            this.Answ2.Text = "Answ2";
            this.Answ2.UseVisualStyleBackColor = true;
            // 
            // Answ3
            // 
            this.Answ3.AutoSize = true;
            this.Answ3.Location = new System.Drawing.Point(20, 283);
            this.Answ3.Margin = new System.Windows.Forms.Padding(2);
            this.Answ3.Name = "Answ3";
            this.Answ3.Size = new System.Drawing.Size(57, 17);
            this.Answ3.TabIndex = 5;
            this.Answ3.Text = "Answ3";
            this.Answ3.UseVisualStyleBackColor = true;
            // 
            // Answ4
            // 
            this.Answ4.AutoSize = true;
            this.Answ4.Location = new System.Drawing.Point(20, 316);
            this.Answ4.Margin = new System.Windows.Forms.Padding(2);
            this.Answ4.Name = "Answ4";
            this.Answ4.Size = new System.Drawing.Size(57, 17);
            this.Answ4.TabIndex = 6;
            this.Answ4.Text = "Answ4";
            this.Answ4.UseVisualStyleBackColor = true;
            // 
            // NextQwButton
            // 
            this.NextQwButton.Location = new System.Drawing.Point(449, 368);
            this.NextQwButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextQwButton.Name = "NextQwButton";
            this.NextQwButton.Size = new System.Drawing.Size(137, 26);
            this.NextQwButton.TabIndex = 7;
            this.NextQwButton.Text = "Следующий вопрос";
            this.NextQwButton.UseVisualStyleBackColor = true;
            this.NextQwButton.Click += new System.EventHandler(this.NextQwButton_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(20, 368);
            this.Close.Margin = new System.Windows.Forms.Padding(2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 25);
            this.Close.TabIndex = 8;
            this.Close.Text = "Выход";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 426);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NextQwButton);
            this.Controls.Add(this.Answ4);
            this.Controls.Add(this.Answ3);
            this.Controls.Add(this.Answ2);
            this.Controls.Add(this.Answ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QuizHeader);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuestionsForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Прохождение теста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuizHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Answ1;
        private System.Windows.Forms.RadioButton Answ2;
        private System.Windows.Forms.RadioButton Answ3;
        private System.Windows.Forms.RadioButton Answ4;
        private System.Windows.Forms.Button NextQwButton;
        private System.Windows.Forms.Button Close;
    }
}