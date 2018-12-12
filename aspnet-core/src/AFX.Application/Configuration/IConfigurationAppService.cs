using System.Threading.Tasks;
using AFX.Configuration.Dto;

namespace AFX.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
