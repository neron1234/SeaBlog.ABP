using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SeaBlog.Authorization;

namespace SeaBlog
{
    [DependsOn(
        typeof(SeaBlogCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SeaBlogApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SeaBlogAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(DtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SeaBlogApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
