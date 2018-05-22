using HunterGuide.EF.Entities;
using HunterGuide.Helpers.Emums;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterGuide.Forms.ClientUI
{
    public partial class UserMainForm : MetroForm
    {
        private readonly ApplicationUser user;

        public UserMainForm(ApplicationUser user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            UserResultsForm URF = new UserResultsForm();
            URF.ShowDialog();
        }

        private void StartTestButton_Click(object sender, EventArgs e)
        {
            QuestionsForm QF = new QuestionsForm();
            QF.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
