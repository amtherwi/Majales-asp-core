using System.Threading.Tasks;
using Majales.Configuration.Dto;

namespace Majales.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
