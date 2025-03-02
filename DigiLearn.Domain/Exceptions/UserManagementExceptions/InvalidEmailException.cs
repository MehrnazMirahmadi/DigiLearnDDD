using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions
{
    internal class InvalidEmailException : UserManagementException
    {
        public InvalidEmailException() : base("Email Is Inavlid...!")
        {
        }
    }
}
