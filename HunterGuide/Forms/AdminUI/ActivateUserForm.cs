using HunterGuide.EF.Entities;
using HunterGuide.Singletons;
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
    public partial class ActivateUserForm : Form
    {
        private readonly EF.ApplicationContext context;

        private List<ApplicationUser> Users;

        public ActivateUserForm()
        {
            InitializeComponent();

            context = ContextProvider.GetApplicationContext();
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
