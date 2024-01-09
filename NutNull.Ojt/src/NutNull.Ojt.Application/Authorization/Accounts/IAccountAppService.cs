using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.Ojt.Authorization.Accounts.Dto;

namespace NutNull.Ojt.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
