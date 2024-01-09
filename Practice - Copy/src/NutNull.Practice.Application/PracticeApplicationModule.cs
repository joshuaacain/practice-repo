using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NutNull.Practice.Authorization;

namespace NutNull.Practice
{
    [DependsOn(
        typeof(PracticeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PracticeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PracticeAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreatMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PracticeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
