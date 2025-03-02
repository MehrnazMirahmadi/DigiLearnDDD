using DigiLearn.Domain.Exceptions.CourseManagementExceptions;

namespace DigiLearn.Domain.ValueObjects
{
    public record Title
    {
        public string Value { get; }
        private int _validLength = 50;
        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new TitleNullOrEmptyException();
            }

            if (value.Length > _validLength)
            {
                throw new InvalidTitleLenghtException(_validLength);
            }

            Value = value;
        }

        public static implicit operator string(Title title) => title.Value;
        public static implicit operator Title(string title) => new(title);
    }
}
