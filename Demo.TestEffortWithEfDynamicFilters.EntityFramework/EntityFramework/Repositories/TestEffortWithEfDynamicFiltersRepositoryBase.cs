using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Demo.TestEffortWithEfDynamicFilters.EntityFramework.Repositories
{
    public abstract class TestEffortWithEfDynamicFiltersRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestEffortWithEfDynamicFiltersDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestEffortWithEfDynamicFiltersRepositoryBase(IDbContextProvider<TestEffortWithEfDynamicFiltersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestEffortWithEfDynamicFiltersRepositoryBase<TEntity> : TestEffortWithEfDynamicFiltersRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestEffortWithEfDynamicFiltersRepositoryBase(IDbContextProvider<TestEffortWithEfDynamicFiltersDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
