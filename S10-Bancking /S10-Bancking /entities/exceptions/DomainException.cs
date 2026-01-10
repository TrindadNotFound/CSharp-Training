namespace S10_Bancking.entities.exceptions;

public class DomainException : ApplicationException
{
    public  DomainException(string message) : base(message)
    {
    }
}