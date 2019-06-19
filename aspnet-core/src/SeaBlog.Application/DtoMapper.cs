using AutoMapper;
using SeaBlog.BlogEntitys;
using SeaBlog.Blogs.Dto;
using SeaBlog.Categorys.Dto;
using SeaBlog.Configuration;
using SeaBlog.SiteConfigs.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog
{
    internal static class DtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<SiteConfig, SiteConfigOutput>();
            configuration.CreateMap<Category, CategoryDetailOutput>();
            configuration.CreateMap<Blog, BlogDetailOutput>();
        }
    }
}
