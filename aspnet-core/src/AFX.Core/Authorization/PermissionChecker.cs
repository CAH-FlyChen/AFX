using Abp.Authorization;
using AFX.Authorization.Roles;
using AFX.Authorization.Users;

namespace AFX.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
