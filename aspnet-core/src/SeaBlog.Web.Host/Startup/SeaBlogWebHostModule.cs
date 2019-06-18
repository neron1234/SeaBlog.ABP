using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SeaBlog.Configuration;

namespace SeaBlog.Web.Host.Startup
{
    [DependsOn(
       typeof(SeaBlogWebCoreModule))]
    public class SeaBlogWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SeaBlogWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SeaBlogWebHostModule).GetAssembly());
        }
    }
}
