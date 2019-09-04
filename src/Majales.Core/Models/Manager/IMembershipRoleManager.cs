using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMembershipRoleManager: IDomainService
    {

        IEnumerable<MembershipRole> GetAllList();
        MembershipRole GetMembershipRoleByID(int id);
        Task<MembershipRole> Create(MembershipRole entity);
        void Update(MembershipRole entity);
        void Delete(int id);
      
    }
}