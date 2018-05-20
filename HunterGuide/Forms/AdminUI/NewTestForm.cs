using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HunterGuide.Forms.AdminUI
{
    public partial class NewTestForm : MetroForm
    {
        public NewTestForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewTestForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateTestButton_Click(object sender, EventArgs e)
        {
            
                QwestForm QF = new QwestForm();
                QF.ShowDialog();
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
