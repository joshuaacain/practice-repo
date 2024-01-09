using Abp.Application.Services.Dto;

namespace NutNull.Practice.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

