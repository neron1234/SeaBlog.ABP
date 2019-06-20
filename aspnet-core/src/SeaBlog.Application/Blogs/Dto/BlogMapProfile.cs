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
            CreateMap<BlogDetailOutput, Blog>();
            CreateMap<Blog, BlogDetailOutput>().ForMember(x => x.HtmlContent, opt => opt.Ignore());
        }
    }
}
