using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SeaBlog.Categorys.Dto;
using SeaBlog.Repositories;
using SeaBlog.BlogEntitys;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Extensions;

namespace SeaBlog.Categorys
{
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, Guid, PagedCategoryResultRequestDto, CreateCategoryDto, CategoryDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, Guid> repository)
             : base(repository)
        {

        }

        protected override IQueryable<Category> CreateFilteredQuery(PagedCategoryResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), c => c.Name.Contains(input.Keyword));
        }
    }
}
