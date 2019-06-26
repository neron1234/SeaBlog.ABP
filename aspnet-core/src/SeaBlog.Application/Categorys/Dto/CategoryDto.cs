using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Categorys.Dto
{
    [AutoMapFrom(typeof(Category))]
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public int Count { get; set; }
    }
}
