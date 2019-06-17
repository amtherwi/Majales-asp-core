using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Majales.Configuration.Dto;

namespace Majales.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MajalesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
