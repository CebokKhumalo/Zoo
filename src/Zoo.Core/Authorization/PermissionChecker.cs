using Abp.Authorization;
using Zoo.Authorization.Roles;
using Zoo.Authorization.Users;

namespace Zoo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
