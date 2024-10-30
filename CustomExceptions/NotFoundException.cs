public class NotFoundException:BaseException
{
    public NotFoundException(string message) : base(message)
    {
    }

    public NotFoundException(string message, int statusCode) : base(message, statusCode)
    {
    }
}