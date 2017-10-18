using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AowenPlatform.MultiTenancy.Dto;

namespace AowenPlatform.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
