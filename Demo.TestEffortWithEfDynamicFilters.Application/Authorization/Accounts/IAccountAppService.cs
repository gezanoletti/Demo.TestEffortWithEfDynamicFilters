using System.Threading.Tasks;
using Abp.Application.Services;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Accounts.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
