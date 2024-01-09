using Abp.Application.Services;
using NutNull.Ojt.MultiTenancy.Dto;

namespace NutNull.Ojt.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

