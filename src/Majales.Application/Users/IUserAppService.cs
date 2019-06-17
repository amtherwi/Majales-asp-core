using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Majales.Roles.Dto;
using Majales.Users.Dto;

namespace Majales.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
