public class AlreadyExistException:BaseException
{
    public AlreadyExistException(string message):base(message)
    {
        
    }

    public AlreadyExistException(string message, int statusCode):base(message, statusCode)
    {

    }
}