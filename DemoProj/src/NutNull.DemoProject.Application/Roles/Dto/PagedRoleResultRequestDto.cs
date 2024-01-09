using Abp.Application.Services.Dto;

namespace NutNull.DemoProject.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

