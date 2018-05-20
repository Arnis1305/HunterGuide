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
            this.label1 = new System.Windows.Forms.Label();
            this.QwLabel = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вопрос:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // QwLabel
            // 
            this.QwLabel.Location = new System.Drawing.Point(12, 35);
            this.QwLabel.Name = "QwLabel";
            this.QwLabel.Size = new System.Drawing.Size(759, 115);
            this.QwLabel.TabIndex = 1;
            this.QwLabel.Text = "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Варианты ответа:";
            // 
            // Answ1
            // 
            this.Answ1.AutoSize = true;
            this.Answ1.Location = new System.Drawing.Point(15, 215);
            this.Answ1.Name = "Answ1";
            this.Answ1.Size = new System.Drawing.Size(70, 21);
            this.Answ1.TabIndex = 3;
            this.Answ1.TabStop = true;
            this.Answ1.Text = "Answ1";
            this.Answ1.UseVisualStyleBackColor = true;
            // 
            // Answ2
            // 
            this.Answ2.AutoSize = true;
            this.Answ2.Location = new System.Drawing.Point(15, 259);
            this.Answ2.Name = "Answ2";
            this.Answ2.Size = new System.Drawing.Size(70, 21);
            this.Answ2.TabIndex = 4;
            this.Answ2.TabStop = true;
            this.Answ2.Text = "Answ2";
            this.Answ2.UseVisualStyleBackColor = true;
            // 
            // Answ3
            // 
            this.Answ3.AutoSize = true;
            this.Answ3.Location = new System.Drawing.Point(15, 301);
            this.Answ3.Name = "Answ3";
            this.Answ3.Size = new System.Drawing.Size(70, 21);
            this.Answ3.TabIndex = 5;
            this.Answ3.TabStop = true;
            this.Answ3.Text = "Answ3";
            this.Answ3.UseVisualStyleBackColor = true;
            this.Answ3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Answ4
            // 
            this.Answ4.AutoSize = true;
            this.Answ4.Location = new System.Drawing.Point(15, 342);
            this.Answ4.Name = "Answ4";
            this.Answ4.Size = new System.Drawing.Size(70, 21);
            this.Answ4.TabIndex = 6;
            this.Answ4.TabStop = true;
            this.Answ4.Text = "Answ4";
            this.Answ4.UseVisualStyleBackColor = true;
            // 
            // NextQwButton
            // 
            this.NextQwButton.Location = new System.Drawing.Point(588, 406);
            this.NextQwButton.Name = "NextQwButton";
            this.NextQwButton.Size = new System.Drawing.Size(183, 32);
            this.NextQwButton.TabIndex = 7;
            this.NextQwButton.Text = "Следующий вопрос";
            this.NextQwButton.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(15, 406);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 31);
            this.Close.TabIndex = 8;
            this.Close.Text = "Выход";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.NextQwButton);
            this.Controls.Add(this.Answ4);
            this.Controls.Add(this.Answ3);
            this.Controls.Add(this.Answ2);
            this.Controls.Add(this.Answ1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QwLabel);
            this.Controls.Add(this.label1);
            this.Name = "QuestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QwLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Answ1;
        private System.Windows.Forms.RadioButton Answ2;
        private System.Windows.Forms.RadioButton Answ3;
        private System.Windows.Forms.RadioButton Answ4;
        private System.Windows.Forms.Button NextQwButton;
        private System.Windows.Forms.Button Close;
    }
}