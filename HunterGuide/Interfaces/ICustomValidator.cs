using System;

namespace HunterGuide.Interfaces 
{
    public interface ICustomValidator<T>
    {
        void Validate(T value);

        ICustomValidator<T> RuleFor(Func<T, bool> rule);

        ICustomValidator<T> WithMessage(string message);
    }
}
