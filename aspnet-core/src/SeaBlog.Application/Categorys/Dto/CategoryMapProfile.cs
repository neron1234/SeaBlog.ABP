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
            CreateMap<CategoryDetailOutput, Category>();
            CreateMap<Category, CategoryDetailOutput>().ForMember(x => x.Count, opt => opt.Ignore());
        }
    }
}
