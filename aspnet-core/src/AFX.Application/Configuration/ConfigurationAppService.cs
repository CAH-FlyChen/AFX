using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AFX.Configuration.Dto;

namespace AFX.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AFXAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
