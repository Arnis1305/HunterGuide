namespace HunterGuide.Forms.AdminUI
{
    partial class QwestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QwestForm));
            this.NextButton = new System.Windows.Forms.Button();
            this.RightAnswerBox = new System.Windows.Forms.TextBox();
            this.answ4 = new System.Windows.Forms.TextBox();
            this.answ3 = new System.Windows.Forms.TextBox();
            this.answ2 = new System.Windows.Forms.TextBox();
            this.answ1 = new System.Windows.Forms.TextBox();
            this.QwestBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(693, 396);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 15;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // RightAnswerBox
            // 
            this.RightAnswerBox.Location = new System.Drawing.Point(175, 353);
            this.RightAnswerBox.Margin = new System.Windows.Forms.Padding(4);
            this.RightAnswerBox.Name = "RightAnswerBox";
            this.RightAnswerBox.Size = new System.Drawing.Size(617, 22);
            this.RightAnswerBox.TabIndex = 14;
            // 
            // answ4
            // 
            this.answ4.Location = new System.Drawing.Point(115, 306);
            this.answ4.Margin = new System.Windows.Forms.Padding(4);
            this.answ4.Name = "answ4";
            this.answ4.Size = new System.Drawing.Size(677, 22);
            this.answ4.TabIndex = 13;
            // 
            // answ3
            // 
            this.answ3.Location = new System.Drawing.Point(115, 258);
            this.answ3.Margin = new System.Windows.Forms.Padding(4);
            this.answ3.Name = "answ3";
            this.answ3.Size = new System.Drawing.Size(677, 22);
            this.answ3.TabIndex = 12;
            // 
            // answ2
            // 
            this.answ2.Location = new System.Drawing.Point(115, 205);
            this.answ2.Margin = new System.Windows.Forms.Padding(4);
            this.answ2.Name = "answ2";
            this.answ2.Size = new System.Drawing.Size(677, 22);
            this.answ2.TabIndex = 11;
            // 
            // answ1
            // 
            this.answ1.Location = new System.Drawing.Point(115, 153);
            this.answ1.Margin = new System.Windows.Forms.Padding(4);
            this.answ1.Name = "answ1";
            this.answ1.Size = new System.Drawing.Size(677, 22);
            this.answ1.TabIndex = 10;
            // 
            // QwestBox
            // 
            this.QwestBox.Location = new System.Drawing.Point(38, 89);
            this.QwestBox.Margin = new System.Windows.Forms.Padding(4);
            this.QwestBox.Multiline = true;
            this.QwestBox.Name = "QwestBox";
            this.QwestBox.Size = new System.Drawing.Size(755, 47);
            this.QwestBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 306);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вопрос:\r\n\r\n\r\n\r\n\r\nОтвет №1:\r\n\r\n\r\nОтвет №2:\r\n\r\n\r\nОтвет №3:\r\n\r\n\r\nОтвет №4:\r\n\r\n\r\nПрав" +
    "ильный ответ: ";
            // 
            // QwestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 460);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RightAnswerBox);
            this.Controls.Add(this.answ4);
            this.Controls.Add(this.answ3);
            this.Controls.Add(this.answ2);
            this.Controls.Add(this.answ1);
            this.Controls.Add(this.QwestBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QwestForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Новый вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox RightAnswerBox;
        private System.Windows.Forms.TextBox answ4;
        private System.Windows.Forms.TextBox answ3;
        private System.Windows.Forms.TextBox answ2;
        private System.Windows.Forms.TextBox answ1;
        private System.Windows.Forms.TextBox QwestBox;
        private System.Windows.Forms.Label label1;
    }
}