using Abp.Application.Services.Dto;

namespace NutNull.Ojt.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

