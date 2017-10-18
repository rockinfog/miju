using System.Threading.Tasks;
using Abp.Application.Services;
using AowenPlatform.Authorization.Accounts.Dto;

namespace AowenPlatform.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
