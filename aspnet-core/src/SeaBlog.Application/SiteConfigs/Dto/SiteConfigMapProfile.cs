using AutoMapper;
using SeaBlog.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.SiteConfigs.Dto
{
    public class SiteConfigMapProfile : Profile
    {
        public SiteConfigMapProfile()
        {
            CreateMap<SiteConfigOutput, SiteConfig>();
        }
    }
}
