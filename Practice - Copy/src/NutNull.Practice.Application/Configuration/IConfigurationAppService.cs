using System.Threading.Tasks;
using NutNull.Practice.Configuration.Dto;

namespace NutNull.Practice.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
