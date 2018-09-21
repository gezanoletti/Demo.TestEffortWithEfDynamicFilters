using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Roles;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Users;
using Demo.TestEffortWithEfDynamicFilters.MultiTenancy;

namespace Demo.TestEffortWithEfDynamicFilters.EntityFramework
{
    public class TestEffortWithEfDynamicFiltersDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TestEffortWithEfDynamicFiltersDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TestEffortWithEfDynamicFiltersDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TestEffortWithEfDynamicFiltersDbContext since ABP automatically handles it.
         */
        public TestEffortWithEfDynamicFiltersDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TestEffortWithEfDynamicFiltersDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TestEffortWithEfDynamicFiltersDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
