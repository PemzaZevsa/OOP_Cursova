namespace CourseworkOOP.Iterfaces
{
    public interface IPayble
    {
        static event Action paymentError;
        static event Action paymentComplete;
        decimal Payment();
    }
}
