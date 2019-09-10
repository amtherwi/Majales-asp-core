using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.TopicClassification.DTO;

namespace Majales.TopicClassification
{
    public interface ITopicClassificationAppService : IApplicationService 
    {
        IEnumerable<GetTopicClassificationOutput> ListAll();
        Task Create(CreateTopicClassificationInput input);
        void Update(UpdateTopicClassificationInput input);
        void Delete(DeleteTopicClassificationInput input);
        GetTopicClassificationOutput GetTopicClassificationById(GetTopicClassificationInput input);
    }
}
