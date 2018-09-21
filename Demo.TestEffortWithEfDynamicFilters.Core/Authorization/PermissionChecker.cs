using Abp.Authorization;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Roles;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Users;

namespace Demo.TestEffortWithEfDynamicFilters.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
