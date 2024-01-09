using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using NutNull.Ojt.Configuration.Dto;

namespace NutNull.Ojt.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OjtAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
