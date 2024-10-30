public class InternalServerException:BaseException
{
    public InternalServerException(string message) : base(message)
    {
    }

    public InternalServerException(string message, int statusCode) : base(message, statusCode)
    {
    }
}