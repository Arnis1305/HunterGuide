namespace HunterGuide.Forms.ClientUI
{
    partial class UserResultsForm
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
            this.UserResultsDataGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserResultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // UserResultsDataGrid
            // 
            this.UserResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserResultsDataGrid.Location = new System.Drawing.Point(17, 64);
            this.UserResultsDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserResultsDataGrid.Name = "UserResultsDataGrid";
            this.UserResultsDataGrid.RowTemplate.Height = 24;
            this.UserResultsDataGrid.Size = new System.Drawing.Size(548, 292);
            this.UserResultsDataGrid.TabIndex = 27;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(501, 360);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(64, 24);
            this.CloseButton.TabIndex = 21;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 394);
            this.Controls.Add(this.UserResultsDataGrid);
            this.Controls.Add(this.CloseButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserResultsForm";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Мои результаты";
            ((System.ComponentModel.ISupportInitialize)(this.UserResultsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView UserResultsDataGrid;
        private System.Windows.Forms.Button CloseButton;
    }
}