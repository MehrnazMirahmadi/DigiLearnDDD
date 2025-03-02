using DigiLearn.Domain.Exceptions.UserManagementExceptions;
using System.Text.RegularExpressions;

namespace DigiLearn.Domain.ValueObjects
{
    public record Password
    {
        public string Value { get; }
        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new PasswordNullOrEmptyException();
            }

            string pattern = "[^a-zA-Z0-9]";

            var regex = new Regex(pattern);

            if (!regex.IsMatch(value))
            {
                throw new InvalidPasswordException();
            }

            Value = value;
        }

        public static implicit operator string(Password password) => password.Value;
        public static implicit operator Password(string password) => new(password);
    }

}
