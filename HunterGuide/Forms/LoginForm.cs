using HunterGuide.EF.Entities;
using HunterGuide.Exceptions;
using HunterGuide.Forms.AdminUI;
using HunterGuide.Helpers;
using HunterGuide.Models;
using HunterGuide.Singletons;
using HunterGuide.Validators;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms
{
    public partial class LoginForm : Form
    {
        private readonly EF.ApplicationContext context;
        private LoginModelValidator loginValidator;

        public LoginForm()
        {
            InitializeComponent();

            context = ContextProvider.GetApplicationContext();
            loginValidator = new LoginModelValidator();
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
            try 
            {
                LoginModel model = GetLoginModelFromInputs();
                loginValidator.Validate(model);
                TryToLogin(model);
            }
            catch (ValidationException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TryToLogin(LoginModel model) 
        {
            model.Password = HashGenerator.GenerateHash(model.Password);
            var appUser = context.Users.FirstOrDefault(u => u.Username.Equals(model.Username) && u.PasswordHash.Equals(model.Password));
            if (appUser == null) 
            {
                MessageBox.Show("Invalid credentials");
                return;
            }
            HandleSuccessfullLogin(appUser);
        }

        private void HandleSuccessfullLogin(ApplicationUser user) 
        {
            if (UserInRole(user, "Admin"))
            {
                ShowAdminUIMainForm(user);
                return;
            }

            if (UserInRole(user, "User")) {
                MessageBox.Show("you in role 'User'");
            }
        }

        private bool UserInRole(ApplicationUser user, string roleName) 
        {
            return context.Roles.Any(r => r.RoleName.Equals(roleName) && r.Id == user.RoleId);
        } 

        private void ShowAdminUIMainForm(ApplicationUser user)
        {
            AdminMainForm adminMainForm = new AdminMainForm(user);
            Hide();
            adminMainForm.FormClosed += (s, args) => HandleChildFormClosed(s, args);
            adminMainForm.Show();
        }

        private void HandleChildFormClosed(object sender, FormClosedEventArgs args)
        {
            if (args.CloseReason == CloseReason.UserClosing)
            {
                Close();
                return;
            }
            Show();
        }

        private LoginModel GetLoginModelFromInputs() 
        {
            return new LoginModel 
            {
                Username = UsernameInput.Text,
                Password = PasswordInput.Text
            };
        }
    }
}
