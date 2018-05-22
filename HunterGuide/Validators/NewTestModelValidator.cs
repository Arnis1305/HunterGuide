using HunterGuide.Interfaces;
using HunterGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterGuide.Validators 
{
    public class NewTestModelValidator : ICustomValidator<NewTestModel> {
        private ICustomValidator<NewTestModel> customValidator;

        public NewTestModelValidator() {
            customValidator = new CustomValidator<NewTestModel>();

            SetDefaultRules();
        }

        public void Validate(NewTestModel model) {
            customValidator.Validate(model);
        }

        public ICustomValidator<NewTestModel> RuleFor(Func<NewTestModel, bool> rule) {
            return customValidator.RuleFor(rule);
        }

        public ICustomValidator<NewTestModel> WithMessage(string message) {
            return customValidator.WithMessage(message);
        }

        private void SetDefaultRules() {
            customValidator
                .RuleFor(nm => nm.Name.Length >= 5)
                .WithMessage("The name of the test should be at least 5 characters long");

            customValidator
                .RuleFor(nm => !string.IsNullOrEmpty(nm.TopicName))
                .WithMessage("Topic name should be chosen");

            customValidator
                .RuleFor(nm => !string.IsNullOrEmpty(nm.TypeName))
                .WithMessage("Type name should be chosen");
        }
    }
}
