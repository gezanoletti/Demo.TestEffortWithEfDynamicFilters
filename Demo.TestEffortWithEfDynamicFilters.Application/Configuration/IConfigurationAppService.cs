using System.Threading.Tasks;
using Abp.Application.Services;
using Demo.TestEffortWithEfDynamicFilters.Configuration.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}