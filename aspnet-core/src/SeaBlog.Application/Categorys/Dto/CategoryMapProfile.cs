using AutoMapper;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Categorys.Dto
{
    public class CategoryMapProfile : Profile
    {
        public CategoryMapProfile()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryDto, Category>()
                .ForMember(x => x.BlogCategories, opt => opt.Ignore());
        }
    }
}
