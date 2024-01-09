using Abp.Authorization;
using NutNull.Ojt.Authorization.Roles;
using NutNull.Ojt.Authorization.Users;

namespace NutNull.Ojt.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
