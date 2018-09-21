using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Demo.TestEffortWithEfDynamicFilters.MultiTenancy.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
