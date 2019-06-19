using SeaBlog.SiteConfigs.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.SiteConfigs
{
    public interface ISiteConfigAppService
    {
        SiteConfigOutput GetSiteConfig();
    }
}
