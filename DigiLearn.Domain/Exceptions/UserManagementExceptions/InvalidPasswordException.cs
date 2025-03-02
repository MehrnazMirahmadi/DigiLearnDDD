using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidPasswordException : UserManagementException
    {
        public InvalidPasswordException() : base("Password Is Invalid...!")
        {
        }
    }
}
