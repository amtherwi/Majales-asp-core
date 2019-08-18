using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;

namespace Majales.Models
{
    public interface IMajlesManager:IDomainService
    {
        IEnumerable<Majles> GetAllList();
        Majles GetMajlesByID(int id);
        Task<Majles> create(Majles entity);
        void update(Majles entity);
        void delete(int id);

    }
}