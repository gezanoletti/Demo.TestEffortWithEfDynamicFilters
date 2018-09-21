using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using Demo.TestEffortWithEfDynamicFilters.EntityFramework;

namespace Demo.TestEffortWithEfDynamicFilters.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<TestEffortWithEfDynamicFiltersDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
