using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MajlisMembership.DTO;

namespace Majales.MajlisMembership
{
    public interface IMajlisMembershipAppService: IApplicationService
    {
        IEnumerable<GetMajlisMembershipOutput> GetAll();
        Task Create(CreateMajlisMembershipInput input);
        void Update(UpdateMajlisMembershipInput input);
        void Delete(DeleteMajlisMembershipInput input);
        GetMajlisMembershipOutput GetMajlisMembershipById(GetMajlisMembershipInput input);
    }
}
