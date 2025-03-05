using DigiLearn.Domain.Primitives;
using DigiLearn.Domain.ValueObjects;

namespace DigiLearn.Domain.Entities.UserManagement;

public class Role : BaseEntity
{

    private RoleName _roleName;
    private LinkedList<UserRole> _userRoles;
    internal Role(BaseId id, RoleName roleName) : base(id)
    {
        _roleName = roleName;
    }

    public Role(BaseId id) : base(id)
    {

    }
}
