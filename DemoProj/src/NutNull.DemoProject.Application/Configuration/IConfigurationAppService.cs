using System.Threading.Tasks;
using NutNull.DemoProject.Configuration.Dto;

namespace NutNull.DemoProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
