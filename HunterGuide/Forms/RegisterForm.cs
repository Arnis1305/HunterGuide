using System;
using System.Windows.Forms;
using HunterGuide.Validators;
using HunterGuide.Models;
using HunterGuide.Singletons;
using HunterGuide.Exceptions;
using AutoMapper;
using HunterGuide.Helpers;
using HunterGuide.EF.Entities;
using System.Linq;

namespace HunterGuide.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;
        private RegistrationModelValidator registrationValidator;
        
        public RegisterForm()
        {
            InitializeComponent();

            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();
            registrationValidator = new RegistrationModelValidator();
        }

        private void CloseButton_Click(object sender, EventArgs e) 
        {
            Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e) 
        {
            try 
            {
                RegistrationModel model = GetRegistrationModelFromInputs();
                registrationValidator.Validate(model);
                RegisterUser(model);
                Close();
            }
            catch(ValidationException ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterUser(RegistrationModel model) 
        {
            model.Password = HashGenerator.GenerateHash(model.Password);
            ApplicationUser appUser = mapper.Map<RegistrationModel, ApplicationUser>(model);
            appUser.RoleId = context.Roles.First(r => r.RoleName.Equals("User")).Id;
            context.Users.Add(appUser);
            context.SaveChanges();
        }

        private RegistrationModel GetRegistrationModelFromInputs() 
        {
            return new RegistrationModel 
            {
                Username = UsernameInput.Text,
                FirstName = FirstNameInput.Text,
                LastName = LastNameInput.Text,
                Password = PasswordInput.Text,
                RepeatPassword = RepeatPasswordInput.Text
            };
        }
    }
}
