using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blogs.Dto
{
    public class BlogSearchInput: PagedResultRequestDto
    {
        public string Keyword { get; set; }

        public string categoryId { get; set; }
    }
}
