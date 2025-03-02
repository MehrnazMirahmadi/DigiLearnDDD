using DigiLearn.Domain.ValueObjects;
using System.Data;

namespace DigiLearn.Domain.Entities.UserManagement
{
    public class UserRole
    {
        private BaseId _roleId;
        private BaseId _userId;

        internal UserRole(BaseId roleId, BaseId userId)
        {
            _roleId = roleId;
            _userId = userId;
        }

        public UserRole()
        {

        }
    }
}
