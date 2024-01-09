using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NutNull.Ojt.Authorization;

namespace NutNull.Ojt
{
    [DependsOn(
        typeof(OjtCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OjtApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OjtAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreatMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OjtApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
