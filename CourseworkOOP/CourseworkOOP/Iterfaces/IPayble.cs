namespace CourseworkOOP.Iterfaces
{
    public interface IPayble
    {
        event Action paymentError;
        event Action paymentComplete;
        decimal Payment();
    }
}
