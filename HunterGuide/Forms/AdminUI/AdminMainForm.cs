using HunterGuide.EF.Entities;
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
    public partial class AdminMainForm : Form
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
            new ActivateUserForm().Show();
        }
    }
}
