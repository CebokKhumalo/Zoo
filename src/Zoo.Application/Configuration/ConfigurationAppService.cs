using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Zoo.Configuration.Dto;

namespace Zoo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ZooAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
