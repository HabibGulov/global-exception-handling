public class BaseException:Exception
{
    public BaseException(string message):base(message)
    {
    }
    public BaseException(string message, int statusCode):base(message)
    {
        this.StatusCode=statusCode;
    }   
    
    public int StatusCode{get; set;}

}