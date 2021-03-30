using Abp.Authorization;
using siasun.MCS.Authorization.Roles;
using siasun.MCS.Authorization.Users;

namespace siasun.MCS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
