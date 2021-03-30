using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using siasun.MCS.Configuration.Dto;

namespace siasun.MCS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MCSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
