using System.Threading.Tasks;
using Abp.Application.Services;
using AFX.Authorization.Accounts.Dto;

namespace AFX.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
