using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.DemoProject.Authorization.Accounts.Dto;

namespace NutNull.DemoProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
