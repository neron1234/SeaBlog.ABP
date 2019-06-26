using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    [AutoMapTo(typeof(Blog))]
    public class CreateBlogDto
    {
        public string Title { get; set; }

        public string Summary { get; set; }

        public string CategoryId { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }
    }
}
