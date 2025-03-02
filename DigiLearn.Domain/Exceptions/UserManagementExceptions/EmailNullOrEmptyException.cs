using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions;

internal class EmailNullOrEmptyException : UserManagementException
{
    public EmailNullOrEmptyException() : base("Email Can Not Be Empty..!")
    {
    }
}
