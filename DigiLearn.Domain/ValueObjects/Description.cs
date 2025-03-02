using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects;

public record Description
{
    public string Value { get; }

    public Description(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new DescriptionNullOrEmptyException();
        }

        if (value.Length > 50)
        {
            throw new InvalidDescriptionLenghtException(50);
        }

        Value = value;
    }

    public static implicit operator string(Description description) => description.Value;
    public static implicit operator Description(string description) => new(description);
}
