using Abp.Authorization;
using SeaBlog.Authorization.Roles;
using SeaBlog.Authorization.Users;

namespace SeaBlog.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
