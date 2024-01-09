using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NutNull.DemoProject.MultiTenancy;

namespace NutNull.DemoProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
