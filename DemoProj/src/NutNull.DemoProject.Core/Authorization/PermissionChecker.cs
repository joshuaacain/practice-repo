using Abp.Authorization;
using NutNull.DemoProject.Authorization.Roles;
using NutNull.DemoProject.Authorization.Users;

namespace NutNull.DemoProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
