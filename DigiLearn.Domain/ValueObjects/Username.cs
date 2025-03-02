using DigiLearn.Domain.Exceptions.UserManagementExceptions;

namespace DigiLearn.Domain.ValueObjects
{
    public record Username
    {
        public string Value { get; }
        public Username(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new UsernameNullOrEmptyException();
            }


            Value = value;
        }

        public static implicit operator string(Username username) => username.Value;
        public static implicit operator Username(string username) => new(username);
    }
}
