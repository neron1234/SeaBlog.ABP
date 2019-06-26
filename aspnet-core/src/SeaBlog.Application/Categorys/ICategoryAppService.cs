using Abp.Application.Services;
using SeaBlog.BlogEntitys;
using SeaBlog.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.Categorys
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, Guid, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>
    {

    }
}
