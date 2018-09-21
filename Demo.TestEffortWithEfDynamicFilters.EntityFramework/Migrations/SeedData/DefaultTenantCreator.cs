using System.Linq;
using Demo.TestEffortWithEfDynamicFilters.EntityFramework;
using Demo.TestEffortWithEfDynamicFilters.MultiTenancy;

namespace Demo.TestEffortWithEfDynamicFilters.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TestEffortWithEfDynamicFiltersDbContext _context;

        public DefaultTenantCreator(TestEffortWithEfDynamicFiltersDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
