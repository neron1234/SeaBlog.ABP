using Abp.AutoMapper;
using SeaBlog.BlogEntitys;
using SeaBlog.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    [AutoMapFrom(typeof(BlogCategory))]
    public class BlogCategoryDto
    {
        public CategoryDto Category { get; set; }
    }
}
