using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Application.Exceptions;

public class UserWithInputEmailExistsException : UserManagementException
{
    public UserWithInputEmailExistsException() : base("User With Input Email Is Exists...!")
    {
    }
}

