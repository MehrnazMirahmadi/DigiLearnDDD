using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects;

public record Price
{
    public decimal Value { get; }

    public Price(decimal value)
    {
        if (value < 0)
        {
            throw new InvalidPriceException();
        }

        Value = value;
    }

    public static implicit operator decimal(Price price) => price.Value;
    public static implicit operator Price(decimal price) => new(price);
}

