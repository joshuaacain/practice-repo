using Abp.Authorization;
using NutNull.Practice.Authorization.Roles;
using NutNull.Practice.Authorization.Users;

namespace NutNull.Practice.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
