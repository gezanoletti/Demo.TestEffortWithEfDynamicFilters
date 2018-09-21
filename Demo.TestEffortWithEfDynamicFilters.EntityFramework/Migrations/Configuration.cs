using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Demo.TestEffortWithEfDynamicFilters.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace Demo.TestEffortWithEfDynamicFilters.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<TestEffortWithEfDynamicFilters.EntityFramework.TestEffortWithEfDynamicFiltersDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TestEffortWithEfDynamicFilters";
        }

        protected override void Seed(TestEffortWithEfDynamicFilters.EntityFramework.TestEffortWithEfDynamicFiltersDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
