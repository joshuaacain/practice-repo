using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.Practice.Authorization.Accounts.Dto;

namespace NutNull.Practice.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
