using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMemberManager : IDomainService
    {

        IEnumerable<Member> GetAllList();
        Member GetMemberByID(int id);
        Task<Member> Create(Member entity);
        void Update(Member entity);
        void Delete(int id);
      
    }
}