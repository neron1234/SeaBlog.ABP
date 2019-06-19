using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SeaBlog.Configuration;
using SeaBlog.SiteConfigs.Dto;

namespace SeaBlog.SiteConfigs
{
    public class SiteConfigAppService : SeaBlogAppServiceBase, ISiteConfigAppService
    {
        private readonly SiteConfig _siteConfig;

        public SiteConfigAppService(IOptions<SiteConfig> siteConfig)
        {
            _siteConfig = siteConfig.Value;
        }

        public SiteConfigOutput GetSiteConfig()
        {
            var config = _siteConfig;
            return AutoMapper.Mapper.Map<SiteConfigOutput>(config);
        }
    }
}
