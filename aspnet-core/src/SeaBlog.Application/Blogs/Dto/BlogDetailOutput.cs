using Abp.Application.Services.Dto;
using SeaBlog.BlogEntitys;
using SeaBlog.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    public class BlogDetailOutput : AuditedEntityDto<Guid>
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
