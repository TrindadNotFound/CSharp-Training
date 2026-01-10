namespace S10_ExceptionsExample.entities.exceptions;

public class DomainException : ApplicationException
{
    public DomainException(string message) : base(message) { }
}