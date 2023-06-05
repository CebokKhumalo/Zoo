using System.Threading.Tasks;
using Zoo.Configuration.Dto;

namespace Zoo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
