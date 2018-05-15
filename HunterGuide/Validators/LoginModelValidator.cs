using HunterGuide.Interfaces;
using HunterGuide.Models;

namespace HunterGuide.Validators {
    public class LoginModelValidator : ICustomValidator<LoginModel>
    {
        private CustomValidator<LoginModel> customValidator;

        public LoginModelValidator() 
        {
            customValidator = new CustomValidator<LoginModel>();

            SetDefaultRules();
        }

        public void Validate(LoginModel model) 
        {
            customValidator.Validate(model);
        }

        private void SetDefaultRules() 
        {
            customValidator
                .RuleFor(lm => lm.Username.Length >= 3)
                .WithMessage("Please, enter fill field with correct credentials and try again");

            customValidator
                .RuleFor(lm => lm.Password.Length >= 5)
                .WithMessage("Please, enter fill field with correct credentials and try again");
        }
    }
}
