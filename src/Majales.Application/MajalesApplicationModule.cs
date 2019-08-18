using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Majales.Authorization;
using Majales.Majles.DTO;
using Majales.Models;

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
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<CreateMajlesInput, Models.Majles>().ReverseMap();
                config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();
                config.CreateMap<UpdateMajlesInput, Models.Majles>().ReverseMap();
                config.CreateMap<Models.Majles, GetMajlesOutput>().ReverseMap();
            });
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
