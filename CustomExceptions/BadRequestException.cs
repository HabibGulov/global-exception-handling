public class BadRequestException:BaseException
{
    public BadRequestException(string message) : base(message)
    {
    }

    public BadRequestException(string message, int statusCode) : base(message, statusCode)
    {
    }
}