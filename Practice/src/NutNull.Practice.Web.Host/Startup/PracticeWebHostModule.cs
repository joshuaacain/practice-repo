using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NutNull.Practice.Configuration;

namespace NutNull.Practice.Web.Host.Startup
{
    [DependsOn(
       typeof(PracticeWebCoreModule))]
    public class PracticeWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PracticeWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PracticeWebHostModule).GetAssembly());
        }
    }
}
