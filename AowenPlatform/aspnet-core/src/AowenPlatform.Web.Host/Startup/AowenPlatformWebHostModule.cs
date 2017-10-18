using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AowenPlatform.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AowenPlatform.Web.Host.Startup
{
    [DependsOn(
       typeof(AowenPlatformWebCoreModule))]
    public class AowenPlatformWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AowenPlatformWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AowenPlatformWebHostModule).GetAssembly());
        }
    }
}
