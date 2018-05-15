using HunterGuide.Interfaces;
using HunterGuide.Models;
using System;

namespace HunterGuide.Validators {
    public class LoginModelValidator : ICustomValidator<LoginModel>
    {
        private ICustomValidator<LoginModel> customValidator;

        public LoginModelValidator() 
        {
            customValidator = new CustomValidator<LoginModel>();

            SetDefaultRules();
        }

        public void Validate(LoginModel model) 
        {
            customValidator.Validate(model);
        }

        public ICustomValidator<LoginModel> RuleFor(Func<LoginModel, bool> rule) {
            return customValidator.RuleFor(rule);
        }

        public ICustomValidator<LoginModel> WithMessage(string message) {
            return customValidator.WithMessage(message);
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
