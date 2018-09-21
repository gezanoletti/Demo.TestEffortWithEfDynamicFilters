using Abp.MultiTenancy;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Users;

namespace Demo.TestEffortWithEfDynamicFilters.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}