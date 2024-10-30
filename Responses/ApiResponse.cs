public class ApiResponse<T>
{
    public bool IsSuccessed{get; init;}
    public string? Message{get; init;}
    public T? Data{get; init;}

    private ApiResponse(bool isSuccessed, string? message, T? data)
    {
        this.IsSuccessed=isSuccessed;
        this.Message=message;
        this.Data=data;
    }

    public static ApiResponse<T> Success(T? data)
    =>new ApiResponse<T>(true, "Success", data);

    public static ApiResponse<T> Fail(T? data)
    => new ApiResponse<T>(false, "Fail", data);
}