using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NutNull.Ojt.Configuration;

namespace NutNull.Ojt.Web.Host.Startup
{
    [DependsOn(
       typeof(OjtWebCoreModule))]
    public class OjtWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OjtWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OjtWebHostModule).GetAssembly());
        }
    }
}
