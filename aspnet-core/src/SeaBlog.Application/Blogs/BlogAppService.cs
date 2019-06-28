using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SeaBlog.Blogs.Dto;
using SeaBlog.Configuration;
using SeaBlog.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Markdig;
using Abp.Authorization;
using SeaBlog.Authorization;
using SeaBlog.BlogEntitys;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.Extensions;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;

namespace SeaBlog.Blogs
{
    public class BlogAppService : AsyncCrudAppService<Blog, BlogDto, Guid, PagedBlogResultRequestDto, CreateBlogDto, BlogDto>, IBlogAppService
    {
        public BlogAppService(IRepository<Blog, Guid> repository)
            : base(repository)
        {

        }

        protected override IQueryable<Blog> CreateFilteredQuery(PagedBlogResultRequestDto input)
        {
            return Repository.GetAll()
                .Include(b => b.BlogCategories)
                .ThenInclude(b => b.Category)
                .WhereIf(input.IsShow.HasValue, b => b.IsShow == input.IsShow)
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Title.Contains(input.Keyword) || x.Summary.Contains(input.Keyword))
                .WhereIf(!input.CategoryId.IsNullOrWhiteSpace(), x => x.BlogCategories.Select(bc => bc.CategoryID.ToString()).Contains(input.CategoryId));
        }

        protected override async Task<Blog> GetEntityByIdAsync(Guid id)
        {
            var blog = await Repository.GetAll().Include(x => x.BlogCategories).ThenInclude(x => x.Category).FirstOrDefaultAsync(x => x.Id == id);

            if (blog == null)
            {
                throw new EntityNotFoundException(typeof(Blog), id);
            }

            return blog;
        }

        protected override BlogDto MapToEntityDto(Blog entity)
        {
            var result = ObjectMapper.Map<BlogDto>(entity);
            result.HtmlContent = Markdown.ToHtml(entity.Content, new MarkdownPipelineBuilder().UseBootstrap().Build());
            return result;
        }

        [AbpAuthorize(PermissionNames.Pages_Blogs)]
        public override Task<BlogDto> Create(CreateBlogDto input)
        {
            return base.Create(input);
        }

        [AbpAuthorize(PermissionNames.Pages_Blogs)]
        public override Task<BlogDto> Update(BlogDto input)
        {
            return base.Update(input);
        }

        [AbpAuthorize(PermissionNames.Pages_Blogs)]
        public override Task Delete(EntityDto<Guid> input)
        {
            return base.Delete(input);
        }
    }
}
