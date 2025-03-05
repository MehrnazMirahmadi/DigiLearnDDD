using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.UserManagement;

public interface IRoleFactory
{
    Role Create(BaseId id, RoleName roleName);
}
