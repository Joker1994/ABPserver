using System.Threading.Tasks;
using siasun.MCS.Configuration.Dto;

namespace siasun.MCS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
