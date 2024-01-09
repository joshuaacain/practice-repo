using System.Threading.Tasks;
using NutNull.Ojt.Configuration.Dto;

namespace NutNull.Ojt.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
