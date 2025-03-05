using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.UserManagement;

public interface IUserFactory
{
    User Create(BaseId id, Username userName, Password password, Email email, bool isConfirmed);
}
