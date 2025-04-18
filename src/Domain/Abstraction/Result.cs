namespace Domain.Abstraction;

public class Result
{
    protected Result(bool isSuccess, string? message = null, Error[]? error = null)
    {
        IsSuccess = isSuccess;
        Errors = error;
        Message = message;
    }

    public bool IsSuccess { get; }
    
    public string? Message { get; set; }

    public IEnumerable<Error>? Errors { get; }

    public static Result Success() => new (true);

    public static Result Success(string message) => new(true, message);
    
    public static Result<TValue> Success<TValue>(TValue value) => new(true, value:value);
    
    public static Result<TValue> Success<TValue>(string message, TValue value) => new(true, message, value);
    
    public static Result Failure() => new(false);
    
    public static Result Failure(Error error) => new(false, null, [error]);
    
    public static Result Failure(Error[] error) => new(false, null, error);
    public static Result Failure(string message) => new(false, message);
    
    public static Result Failure(string message, Error error) => new(false, message, [error]);
    
    public static Result Failure(string message, Error[] error) => new(false, message, error);
    
    public static Result<TValue> Failure<TValue>(Error[] error) => new(false, error: error);
    
    public static Result<TValue> Failure<TValue>(Error error) => new(false, error: [error]);
    
    public static Result<TValue> Failure<TValue>(string message, Error[] error) => new(false, message, error: error);
    
    public static Result<TValue> Failure<TValue>(string message, Error error) => new(false, message, error: [error]);
    
    public static Result<TValue> Create<TValue>(string message, TValue? value) => value is not null ? Success(message, value) : Failure<TValue>(message, Error.NullValue);
}
