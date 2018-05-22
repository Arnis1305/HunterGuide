using HunterGuide.EF.Entities;
using HunterGuide.Exceptions;
using HunterGuide.Forms.AdminUI;
using HunterGuide.Forms.ClientUI;
using HunterGuide.Helpers;
using HunterGuide.Helpers.Emums;
using HunterGuide.Models;
using HunterGuide.Singletons;
using HunterGuide.Validators;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms
{
    public partial class LoginForm : MetroForm
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
            if (UserInRole(user, "User") && IsAbleToLogin(user)) 
            {
                ShowUserUIMainForm(user);
                return;
            }
        }

        private bool UserInRole(ApplicationUser user, string roleName) 
        {
            return context.Roles.Any(r => r.RoleName.Equals(roleName) && r.Id == user.RoleId);
        }

        private bool IsAbleToLogin(ApplicationUser user) 
        {
            if (user.StatusType == (int)UserStatusType.NotActivated) 
            {
                MessageBox.Show("You are not activated yet, please contact your local administrator for activation");
                return false;
            }
            if (user.StatusType == (int)UserStatusType.Rejected) 
            {
                MessageBox.Show("You have been rejected and not gonna able to use our system");
                return false;
            }
            return true;
        }

        private void ShowUserUIMainForm(ApplicationUser user)
        {
            UserMainForm userMainForm = new UserMainForm(user);
            Hide();
            userMainForm.FormClosed += (s, args) => HandleChildFormClosed(s, args);
            userMainForm.Show();
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
