using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.UserManagement;

public class UserFactory : IUserFactory
{
    public User Create(BaseId id, Username userName, Password password, Email email, bool isConfirmed)
    {
        return new User(id, userName, password, email, isConfirmed);
    }
}
