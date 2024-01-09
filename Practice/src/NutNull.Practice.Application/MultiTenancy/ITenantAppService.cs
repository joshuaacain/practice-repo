using Abp.Application.Services;
using NutNull.Practice.MultiTenancy.Dto;

namespace NutNull.Practice.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

