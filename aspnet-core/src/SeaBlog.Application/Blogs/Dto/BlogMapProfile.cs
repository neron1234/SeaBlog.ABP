using AutoMapper;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    public class BlogMapProfile : Profile
    {
        public BlogMapProfile()
        {
            CreateMap<BlogDto, Blog>();
            CreateMap<BlogDto, Blog>()
                .ForMember(x => x.BlogCategories, opt => opt.Ignore());
        }
    }
}
