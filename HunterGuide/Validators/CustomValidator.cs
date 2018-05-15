using HunterGuide.Exceptions;
using HunterGuide.Interfaces;
using HunterGuide.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HunterGuide.Validators 
{
    public class CustomValidator<T> : ICustomValidator<T>
    {
        private List<RuleMessagePairModel<T>> ruleList;
        private string defaultExceptionMessage;

        public CustomValidator() 
        {
            ruleList = new List<RuleMessagePairModel<T>>();
            defaultExceptionMessage = "rule not passed with value: {0}";
        }

        public void Validate(T value) 
        {
            RuleMessagePairModel<T> ruleNotPassed = ruleList.FirstOrDefault(rule => !rule.Rule(value));
            if (ruleNotPassed != null) 
            {
                throw new ValidationException(string.Format(ruleNotPassed.WithMessage, value.ToString()));
            }
        }

        public CustomValidator<T> RuleFor(Func<T, bool> rule) 
        {
            RuleMessagePairModel<T> pairModel = new RuleMessagePairModel<T> {
                Rule = rule,
                WithMessage = defaultExceptionMessage
            };
            ruleList.Add(pairModel);
            return this;
        }

        public CustomValidator<T> WithMessage(string message) 
        {
            var lastRule = ruleList.ElementAt(ruleList.Count - 1);
            ruleList = ruleList.Select(rule => {
                if (rule == lastRule) {
                    rule.WithMessage = message;
                }
                return rule;
            }).ToList();
            return this;
        }
    }
}
