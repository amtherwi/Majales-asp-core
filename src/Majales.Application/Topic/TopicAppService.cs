using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Topic.DTO;

namespace Majales.Topic
{
    public class TopicAppService : ApplicationService, ITopicAppService
    {
        private readonly ITopicManager _topicManager;

        public TopicAppService(ITopicManager topicManager)
        {
            _topicManager = topicManager;
        }
        public IEnumerable<GetTopicOutput> GetAll()
        {
            var getAll = _topicManager.GetAllList().ToList();
            List<GetTopicOutput> output = Mapper.Map<List<Models.Topic>, List<GetTopicOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateTopicInput input)
        {
            Models.Topic output = Mapper.Map<CreateTopicInput, Models.Topic>(input);
            await _topicManager.Create(output);
        }

        public void Update(UpdateTopicInput input)
        {
            Models.Topic output = Mapper.Map<UpdateTopicInput, Models.Topic>(input);
            _topicManager.Update(output);
        }

        public void Delete(DeleteTopicInput input)
        {
            _topicManager.Delete(input.Id);
        }

        public GetTopicOutput GetTopicById(GetTopicInput input)
        {
            var getTopic = _topicManager.GetTopicByID(input.Id);
            GetTopicOutput output = Mapper.Map<Models.Topic, GetTopicOutput>(getTopic);
            return output;
        }
    }
}
