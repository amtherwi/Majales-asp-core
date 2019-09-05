using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IVoteManager: IDomainService
    {

        IEnumerable<Vote> GetAllList();
        Vote GetVoteByID(int id);
        Task<Vote> Create(Vote entity);
        void Update(Vote entity);
        void Delete(int id);

    }
}