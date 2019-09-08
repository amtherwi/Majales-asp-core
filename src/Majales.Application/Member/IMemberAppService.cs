using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Member.DTO;

namespace Majales.Member
{
    public interface IMemberAppService: IApplicationService
    {
        IEnumerable<GetMemberOutput> ListAll();
        Task Create(CreateMemberInput input);
        void Update(UpdateMemberInput input);
        void Delete(DeleteMemberInput input);
        GetMemberOutput GetMemberById(GetMemberInput input);
    }
}
