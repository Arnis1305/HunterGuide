using HunterGuide.Interfaces;
using HunterGuide.Models;
using System;

namespace HunterGuide.Validators 
{
    public class QuizModelValidator : ICustomValidator<QuizModel>
    {
        private ICustomValidator<QuizModel> customValidator;

        public QuizModelValidator() {
            customValidator = new CustomValidator<QuizModel>();

            SetDefaultRules();
        }

        public void Validate(QuizModel model) {
            customValidator.Validate(model);
        }

        public ICustomValidator<QuizModel> RuleFor(Func<QuizModel, bool> rule) {
            return customValidator.RuleFor(rule);
        }

        public ICustomValidator<QuizModel> WithMessage(string message) {
            return customValidator.WithMessage(message);
        }

        private void SetDefaultRules() {
            customValidator
                .RuleFor(q => q.Question.Length >= 10)
                .WithMessage("Quistion should be at least 10 characters long")
                .RuleFor(q => q.FirstAnswer.Length >= 2)
                .WithMessage("Answer text should be at least 2 characters long")
                .RuleFor(q => q.SecondAnswer.Length >= 2)
                .WithMessage("Answer text should be at least 2 characters long")
                .RuleFor(q => q.ThirdAnswer.Length >= 2)
                .WithMessage("Answer text should be at least 2 characters long")
                .RuleFor(q => q.FourthAnswer.Length >= 2)
                .WithMessage("Answer text should be at least 2 characters long");
        }
    }
}
