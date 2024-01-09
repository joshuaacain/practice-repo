using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NutNull.Practice.Roles.Dto;
using NutNull.Practice.Users.Dto;

namespace NutNull.Practice.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
