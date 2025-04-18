namespace Domain.Abstraction;

public sealed class ValidationResult : Result
{
    private ValidationResult(string message, Error[] errors) : base(false, message, errors){}

    public static ValidationResult WithErrors(Error[] errors) => new("Validation failed", errors);
}
