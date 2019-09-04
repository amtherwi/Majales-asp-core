using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface ITopicClassificationManager: IDomainService
    {

        IEnumerable<TopicClassification> GetAllList();
        TopicClassification GetTopicClassificationByID(int id);
        Task<TopicClassification> Create(TopicClassification entity);
        void Update(TopicClassification entity);
        void Delete(int id);
      
    }
}