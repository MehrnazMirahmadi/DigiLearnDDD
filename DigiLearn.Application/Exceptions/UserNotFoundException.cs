using DigiLearn.Shared.Abstraction.Exceptions;

namespace DigiLearn.Application.Exceptions;
public class UserNotFoundException : UserManagementException
{
    public UserNotFoundException() : base("User Not Found...!")
    {
    }
}