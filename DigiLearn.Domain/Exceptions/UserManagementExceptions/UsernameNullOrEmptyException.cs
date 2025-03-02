using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions
{
    internal class UsernameNullOrEmptyException : UserManagementException
    {
        public UsernameNullOrEmptyException() : base("Username Can Not Be Empty...!")
        {
        }
    }
}
