using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMajlisMembershipManager: IDomainService
    {

        IEnumerable<MajlisMembership> GetAllList();
        MajlisMembership GetMajlisMembershipByID(int id);
        Task<MajlisMembership> Create(MajlisMembership entity);
        void Update(MajlisMembership entity);
        void Delete(int id);
     
    
    }
}