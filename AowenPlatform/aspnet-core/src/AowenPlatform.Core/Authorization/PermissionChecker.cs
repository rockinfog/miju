using Abp.Authorization;
using AowenPlatform.Authorization.Roles;
using AowenPlatform.Authorization.Users;

namespace AowenPlatform.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
