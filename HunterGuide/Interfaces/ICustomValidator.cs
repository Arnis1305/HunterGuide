namespace HunterGuide.Interfaces 
{
    public interface ICustomValidator<T>
    {
        void Validate(T value);
    }
}
