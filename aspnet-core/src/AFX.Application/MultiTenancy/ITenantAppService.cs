using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AFX.MultiTenancy.Dto;

namespace AFX.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
