using System.Threading.Tasks;
using Abp.Application.Services;
using Demo.TestEffortWithEfDynamicFilters.Sessions.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
