namespace Application.Exceptions;

internal class NotFoundException : ApplicationException
{
    public NotFoundException(string message) : base(message) { }
}
