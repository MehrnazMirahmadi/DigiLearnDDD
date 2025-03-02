using DigiLearn.Domain.Exceptions;

namespace DigiLearn.Domain.ValueObjects
{
    public record BaseId
    {
        public Guid Value { get; }

        public BaseId(Guid value)
        {
            if (value == Guid.Empty)
            {
                throw new BaseIdNullException();
            }

            Value = value;
        }

        public static implicit operator Guid(BaseId id) => id.Value;
        public static implicit operator BaseId(Guid id) => new(id);

    }

}
