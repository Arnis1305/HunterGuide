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
            this.ContinueButton = new System.Windows.Forms.Button();
            this.FourthAnswerBox = new System.Windows.Forms.TextBox();
            this.ThirdAnswerBox = new System.Windows.Forms.TextBox();
            this.SecondAnswerBox = new System.Windows.Forms.TextBox();
            this.FirstAnswerBox = new System.Windows.Forms.TextBox();
            this.QwestBox = new System.Windows.Forms.TextBox();
            this.NumQwBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(434, 332);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueButton.TabIndex = 15;
            this.ContinueButton.Text = "Next";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // FourthAnswerBox
            // 
            this.FourthAnswerBox.Location = new System.Drawing.Point(125, 261);
            this.FourthAnswerBox.Name = "FourthAnswerBox";
            this.FourthAnswerBox.Size = new System.Drawing.Size(470, 20);
            this.FourthAnswerBox.TabIndex = 13;
            // 
            // ThirdAnswerBox
            // 
            this.ThirdAnswerBox.Location = new System.Drawing.Point(125, 220);
            this.ThirdAnswerBox.Name = "ThirdAnswerBox";
            this.ThirdAnswerBox.Size = new System.Drawing.Size(470, 20);
            this.ThirdAnswerBox.TabIndex = 12;
            // 
            // SecondAnswerBox
            // 
            this.SecondAnswerBox.Location = new System.Drawing.Point(125, 179);
            this.SecondAnswerBox.Name = "SecondAnswerBox";
            this.SecondAnswerBox.Size = new System.Drawing.Size(470, 20);
            this.SecondAnswerBox.TabIndex = 11;
            // 
            // FirstAnswerBox
            // 
            this.FirstAnswerBox.Location = new System.Drawing.Point(125, 136);
            this.FirstAnswerBox.Name = "FirstAnswerBox";
            this.FirstAnswerBox.Size = new System.Drawing.Size(470, 20);
            this.FirstAnswerBox.TabIndex = 10;
            // 
            // QwestBox
            // 
            this.QwestBox.Location = new System.Drawing.Point(125, 72);
            this.QwestBox.Multiline = true;
            this.QwestBox.Name = "QwestBox";
            this.QwestBox.Size = new System.Drawing.Size(470, 42);
            this.QwestBox.TabIndex = 9;
            // 
            // NumQwBox
            // 
            this.NumQwBox.Location = new System.Drawing.Point(434, 300);
            this.NumQwBox.Maximum = new decimal(new int[] {
            4,
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
            this.NumQwBox.TabIndex = 16;
            this.NumQwBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вопрос #1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 182);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Вопрос #2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Вопрос #3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Вопрос #4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Номер правильного ответа";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(520, 332);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Вопрос";
            // 
            // QwestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 374);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumQwBox);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.FourthAnswerBox);
            this.Controls.Add(this.ThirdAnswerBox);
            this.Controls.Add(this.SecondAnswerBox);
            this.Controls.Add(this.FirstAnswerBox);
            this.Controls.Add(this.QwestBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QwestForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Новый вопрос";
            ((System.ComponentModel.ISupportInitialize)(this.NumQwBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.TextBox FourthAnswerBox;
        private System.Windows.Forms.TextBox ThirdAnswerBox;
        private System.Windows.Forms.TextBox SecondAnswerBox;
        private System.Windows.Forms.TextBox FirstAnswerBox;
        private System.Windows.Forms.TextBox QwestBox;
        public System.Windows.Forms.NumericUpDown NumQwBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label6;
    }
}