using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Demo.TestEffortWithEfDynamicFilters.EntityFramework;

namespace Demo.TestEffortWithEfDynamicFilters
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TestEffortWithEfDynamicFiltersCoreModule))]
    public class TestEffortWithEfDynamicFiltersDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TestEffortWithEfDynamicFiltersDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
