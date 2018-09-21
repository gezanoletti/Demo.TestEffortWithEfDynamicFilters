using Abp.Web.Mvc.Views;

namespace Demo.TestEffortWithEfDynamicFilters.Web.Views
{
    public abstract class TestEffortWithEfDynamicFiltersWebViewPageBase : TestEffortWithEfDynamicFiltersWebViewPageBase<dynamic>
    {

    }

    public abstract class TestEffortWithEfDynamicFiltersWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TestEffortWithEfDynamicFiltersWebViewPageBase()
        {
            LocalizationSourceName = TestEffortWithEfDynamicFiltersConsts.LocalizationSourceName;
        }
    }
}