using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Sessions.Dto;

namespace Majales.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
