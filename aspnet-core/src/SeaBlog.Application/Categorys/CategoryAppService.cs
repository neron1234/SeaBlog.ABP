using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SeaBlog.Categorys.Dto;
using SeaBlog.Repositories;
using SeaBlog.BlogEntitys;
using System.Linq;

namespace SeaBlog.Categorys
{
    public class CategoryAppService : SeaBlogAppServiceBase, ICategoryAppService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryAppService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryDetailOutput>> GetListAsync()
        {
            try
            {
                var list = await _categoryRepository.GetAllListAsync();
                return ObjectMapper.Map<List<CategoryDetailOutput>>(list);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
