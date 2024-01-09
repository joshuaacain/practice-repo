using Abp.Application.Services;
using NutNull.DemoProject.MultiTenancy.Dto;

namespace NutNull.DemoProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

