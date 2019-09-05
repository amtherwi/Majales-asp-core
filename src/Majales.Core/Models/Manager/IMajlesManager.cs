using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMajlesManager:IDomainService
    {

        IEnumerable<Majles> GetAllList();
        Majles GetMajlesByID(int id);
        Task<Majles> Create(Majles entity);
        void Update(Majles entity);
        void Delete(int id);
      
    }
}