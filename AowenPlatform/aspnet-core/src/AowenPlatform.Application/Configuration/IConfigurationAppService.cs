using System.Threading.Tasks;
using AowenPlatform.Configuration.Dto;

namespace AowenPlatform.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}