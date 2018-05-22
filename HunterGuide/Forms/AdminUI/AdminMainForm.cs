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

namespace HunterGuide.Forms.AdminUI
{
    public partial class AdminMainForm : MetroForm
    {
        private readonly ApplicationUser user;

        public AdminMainForm(ApplicationUser user)
        {
            InitializeComponent();

            this.user = user;
            WelcomeLable.Text += string.Format("{0}!", user.Username);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUsersForm activateUserForm = new ManageUsersForm(ManageUsersFormType.ManageNotActivatedUsers);
            activateUserForm.Show();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm(ManageUsersFormType.ManageActivatedUsers);
            manageUsersForm.Show();
        }

        private void manageRolesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            ManageUsersForm manageUsersForm = new ManageUsersForm(ManageUsersFormType.ManageUserRoles);
            manageUsersForm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTestForm NF = new NewTestForm();
            NF.ShowDialog();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllTestForm ATF = new AllTestForm();
            ATF.ShowDialog();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm RF = new ResultsForm();
            RF.ShowDialog();
        }
    }
}
