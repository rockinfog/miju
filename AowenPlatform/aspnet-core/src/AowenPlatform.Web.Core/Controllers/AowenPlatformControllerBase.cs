using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AowenPlatform.Controllers
{
    public abstract class AowenPlatformControllerBase: AbpController
    {
        protected AowenPlatformControllerBase()
        {
            LocalizationSourceName = AowenPlatformConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}