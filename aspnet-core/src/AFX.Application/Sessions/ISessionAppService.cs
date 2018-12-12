using System.Threading.Tasks;
using Abp.Application.Services;
using AFX.Sessions.Dto;

namespace AFX.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
