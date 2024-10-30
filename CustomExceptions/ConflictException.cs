public class ConflictException:BaseException
{
    public ConflictException(string message) : base(message)
    {
    }

    public ConflictException(string message, int statusCode) : base(message, statusCode)
    {
    }
}