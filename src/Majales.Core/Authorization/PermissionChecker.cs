using Abp.Authorization;
using Majales.Authorization.Roles;
using Majales.Authorization.Users;

namespace Majales.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
