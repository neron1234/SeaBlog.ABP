using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    [AutoMapFrom(typeof(Blog))]
    public class BlogDto : AuditedEntityDto<Guid>
    {
        public string Slug { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public string HtmlContent { get; set; }

        public bool IsShow { get; set; }

        public virtual List<BlogCategoryDto> BlogCategories { get; set; }
    }
}
