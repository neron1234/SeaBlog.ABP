using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SeaBlog.BlogEntitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Categorys.Dto
{
    [AutoMapTo(typeof(Category))]
    public class CreateCategoryDto
    {
        public string Name { get; set; }
    }
}
