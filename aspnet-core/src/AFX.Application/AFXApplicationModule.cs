using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AFX.Authorization;

namespace AFX
{
    [DependsOn(
        typeof(AFXCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AFXApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AFXAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AFXApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
