using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AowenPlatform.Configuration.Dto;

namespace AowenPlatform.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AowenPlatformAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
