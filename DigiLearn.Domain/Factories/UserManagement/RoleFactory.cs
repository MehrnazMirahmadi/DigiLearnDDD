using DigiLearn.Domain.Entities.UserManagement;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Factories.UserManagement;

public class RoleFactory : IRoleFactory
{
    public Role Create(BaseId id, RoleName roleName)
    {
        return new Role(id, roleName);
    }
}

