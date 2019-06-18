using Abp.Application.Services;
using SeaBlog.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SeaBlog.Categorys
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<List<CategoryDetailOutput>> GetListAsync();
    }
}
