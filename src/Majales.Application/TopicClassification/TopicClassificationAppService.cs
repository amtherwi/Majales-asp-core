using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.TopicClassification.DTO;

namespace Majales.TopicClassification
{
    public class TopicClassificationAppService : ApplicationService, ITopicClassificationAppService
    {
        private readonly ITopicClassificationManager _topicClassificationManager;

        public TopicClassificationAppService(ITopicClassificationManager membershipRoleManager)
        {
            _topicClassificationManager = membershipRoleManager;
        }
        public IEnumerable<GetTopicClassificationOutput> GetAll()
        {
            var getAll = _topicClassificationManager.GetAllList().ToList();
            List<GetTopicClassificationOutput> output = Mapper.Map<List<Models.TopicClassification>, List<GetTopicClassificationOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateTopicClassificationInput input)
        {
            Models.TopicClassification output = Mapper.Map<CreateTopicClassificationInput, Models.TopicClassification>(input);
            await _topicClassificationManager.Create(output);
        }

        public void Update(UpdateTopicClassificationInput input)
        {
            Models.TopicClassification output = Mapper.Map<UpdateTopicClassificationInput, Models.TopicClassification>(input);
            _topicClassificationManager.Update(output);
        }

        public void Delete(DeleteTopicClassificationInput input)
        {
            _topicClassificationManager.Delete(input.Id);
        }

        public GetTopicClassificationOutput GetTopicClassificationById(GetTopicClassificationInput input)
        {
            var getTopicClassification = _topicClassificationManager.GetTopicClassificationByID(input.Id);
            GetTopicClassificationOutput output = Mapper.Map<Models.TopicClassification, GetTopicClassificationOutput>(getTopicClassification);
            return output;
        }
    }
}
