using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects
{
    public record FullName
    {
        public string Value { get; }

        private int _validLenght = 30;

        public FullName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new FullNameNullOrEmptyException();
            }

            if (value.Length > _validLenght)
            {
                throw new InvalidFullNameLenghtException(_validLenght);
            }

            Value = value;
        }

        public static implicit operator string(FullName fullName) => fullName.Value;
        public static implicit operator FullName(string fullName) => new(fullName);
    }
}
