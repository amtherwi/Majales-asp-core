using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Majales.Authorization;

namespace Majales
{
    [DependsOn(
        typeof(MajalesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MajalesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MajalesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MajalesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
