using Demo.TestEffortWithEfDynamicFilters.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Demo.TestEffortWithEfDynamicFilters.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestEffortWithEfDynamicFiltersDbContext _context;

        public InitialHostDbBuilder(TestEffortWithEfDynamicFiltersDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
