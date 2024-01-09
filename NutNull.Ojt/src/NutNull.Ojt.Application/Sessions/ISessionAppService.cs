using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.Ojt.Sessions.Dto;

namespace NutNull.Ojt.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
