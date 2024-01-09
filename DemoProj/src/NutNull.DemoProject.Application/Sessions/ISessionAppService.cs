using System.Threading.Tasks;
using Abp.Application.Services;
using NutNull.DemoProject.Sessions.Dto;

namespace NutNull.DemoProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
