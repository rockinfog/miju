using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AowenPlatform.Roles.Dto;
using AowenPlatform.Users.Dto;

namespace AowenPlatform.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}