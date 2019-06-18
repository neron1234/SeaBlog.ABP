using AutoMapper;
using SeaBlog.BlogEntitys;
using SeaBlog.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog
{
    internal static class DtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<Category, CategoryDetailOutput>();
        }
    }
}
