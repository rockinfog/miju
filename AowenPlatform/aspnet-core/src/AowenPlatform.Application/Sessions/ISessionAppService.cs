using System.Threading.Tasks;
using Abp.Application.Services;
using AowenPlatform.Sessions.Dto;

namespace AowenPlatform.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
