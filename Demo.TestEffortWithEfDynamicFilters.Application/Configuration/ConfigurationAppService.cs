using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Demo.TestEffortWithEfDynamicFilters.Configuration.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestEffortWithEfDynamicFiltersAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
