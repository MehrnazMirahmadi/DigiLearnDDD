using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects;

public record Biography
{
    public string Value { get; }

    public Biography(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new BiographyNullOrEmptyException();
        }

        if (value.Length > 300)
        {
            throw new InvalidBiographyLenghtException();
        }

        Value = value;
    }

    public static implicit operator string(Biography biography) => biography.Value;
    public static implicit operator Biography(string biography) => new(biography);
}
