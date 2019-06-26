using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Categorys.Dto
{
    public class PagedCategoryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}
