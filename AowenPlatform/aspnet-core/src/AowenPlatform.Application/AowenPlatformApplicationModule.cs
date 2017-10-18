using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AowenPlatform.Authorization;

namespace AowenPlatform
{
    [DependsOn(
        typeof(AowenPlatformCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AowenPlatformApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AowenPlatformAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(AowenPlatformApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}