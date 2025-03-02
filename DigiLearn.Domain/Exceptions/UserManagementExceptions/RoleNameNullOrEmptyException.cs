using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Domain.Exceptions.UserManagementExceptions;

internal class RoleNameNullOrEmptyException : UserManagementException
{
    public RoleNameNullOrEmptyException() : base("Role Name Can Not Be Empty...!")
    {
    }
}
