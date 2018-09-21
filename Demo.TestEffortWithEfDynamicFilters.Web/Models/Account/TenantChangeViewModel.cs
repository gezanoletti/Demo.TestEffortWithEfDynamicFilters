using Abp.AutoMapper;
using Demo.TestEffortWithEfDynamicFilters.Sessions.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}