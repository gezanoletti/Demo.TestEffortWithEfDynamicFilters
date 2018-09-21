using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Demo.TestEffortWithEfDynamicFilters.EntityFramework;

namespace Demo.TestEffortWithEfDynamicFilters.Migrator
{
    [DependsOn(typeof(TestEffortWithEfDynamicFiltersDataModule))]
    public class TestEffortWithEfDynamicFiltersMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestEffortWithEfDynamicFiltersDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}