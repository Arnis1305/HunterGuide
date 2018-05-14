using HunterGuide.EF.Entities;
using HunterGuide.Helpers;
using HunterGuide.Singletons;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms
{
    public partial class LoginForm : Form
    {
        private readonly EF.ApplicationContext context;

        public LoginForm()
        {
            InitializeComponent();
            context = ContextProvider.GetApplicationContext();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Owner = this;
            registerForm.FormClosed += (s, args) => Show();
            registerForm.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UsernameInput.Text) || string.IsNullOrEmpty(PasswordInput.Text))
            {
                ShowErrorMessage();
                return;
            }
            ApplicationUser user = TryToLogin(UsernameInput.Text, PasswordInput.Text);
            if (user == null)
            {
                ShowErrorMessage();
                return;
            }
        }

        private ApplicationUser TryToLogin(string username, string password)
        {
            string passwordHash = HashGenerator.GenerateHash(password);
            return context.Users.FirstOrDefault(u => u.Username.Equals(username) && u.PasswordHash.Equals(passwordHash));
        }

        private void HandleLogin(ApplicationUser user)
        {
            Role userRole = user.Role;
        }

        private void ShowErrorMessage()
        {
            MessageBox.Show("Please, enter fill field with correct credentials and try again");
            return;
        }
    }
}
