using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Demo.TestEffortWithEfDynamicFilters.Roles.Dto;
using Demo.TestEffortWithEfDynamicFilters.Users.Dto;

namespace Demo.TestEffortWithEfDynamicFilters.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}