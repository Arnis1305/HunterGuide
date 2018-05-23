namespace HunterGuide.Forms.ClientUI
{
    partial class TimeResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeResultForm));
            this.lab1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TestTypeLable = new System.Windows.Forms.Label();
            this.TestNameLable = new System.Windows.Forms.Label();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(83, 68);
            this.lab1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(99, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Тип тестирования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название теста";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Оценка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestTypeLable
            // 
            this.TestTypeLable.AutoSize = true;
            this.TestTypeLable.Location = new System.Drawing.Point(221, 68);
            this.TestTypeLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestTypeLable.Name = "TestTypeLable";
            this.TestTypeLable.Size = new System.Drawing.Size(52, 13);
            this.TestTypeLable.TabIndex = 6;
            this.TestTypeLable.Text = "TestType";
            // 
            // TestNameLable
            // 
            this.TestNameLable.AutoSize = true;
            this.TestNameLable.Location = new System.Drawing.Point(218, 97);
            this.TestNameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestNameLable.Name = "TestNameLable";
            this.TestNameLable.Size = new System.Drawing.Size(35, 13);
            this.TestNameLable.TabIndex = 8;
            this.TestNameLable.Text = "label7";
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(218, 126);
            this.MarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(35, 13);
            this.MarkLabel.TabIndex = 9;
            this.MarkLabel.Text = "label8";
            // 
            // TimeResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 207);
            this.Controls.Add(this.MarkLabel);
            this.Controls.Add(this.TestNameLable);
            this.Controls.Add(this.TestTypeLable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimeResultForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Итоги теста:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TestTypeLable;
        private System.Windows.Forms.Label TestNameLable;
        private System.Windows.Forms.Label MarkLabel;
    }
}