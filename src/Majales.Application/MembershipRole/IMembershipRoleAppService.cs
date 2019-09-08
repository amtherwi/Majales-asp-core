using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MembershipRole.DTO;

namespace Majales.MembershipRole
{
    public interface IMembershipRoleAppService: IApplicationService
    {
        IEnumerable<GetMembershipRoleOutput> ListAll();
        Task Create(CreateMembershipRoleInput input);
        void Update(UpdateMembershipRoleInput input);
        void Delete(DeleteMembershipRoleInput input);
        GetMembershipRoleOutput GetMembershipRoleById(GetMembershipRoleInput input);
    }
}
