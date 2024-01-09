using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.Practice.Sessions.Dto;

namespace NutNull.Practice.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
