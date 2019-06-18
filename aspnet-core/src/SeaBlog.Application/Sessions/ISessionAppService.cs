using System.Threading.Tasks;
using Abp.Application.Services;
using SeaBlog.Sessions.Dto;

namespace SeaBlog.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
