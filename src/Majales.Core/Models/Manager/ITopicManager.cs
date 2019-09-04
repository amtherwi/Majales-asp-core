using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface ITopicManager: IDomainService
    {

        IEnumerable<Topic> GetAllList();
        Topic GetTopicByID(int id);
        Task<Topic> Create(Topic entity);
        void Update(Topic entity);
        void Delete(int id);
      
    }
}