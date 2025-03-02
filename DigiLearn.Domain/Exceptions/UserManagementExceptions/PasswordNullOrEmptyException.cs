using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions
{
    internal class PasswordNullOrEmptyException : UserManagementException
    {
        public PasswordNullOrEmptyException() : base("Password Can Not Be Null Or Empty")
        {
        }
    }

}
