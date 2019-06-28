using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    public class PagedBlogResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

        public string CategoryId { get; set; }

        public bool? IsShow { get; set; }
    }
}
