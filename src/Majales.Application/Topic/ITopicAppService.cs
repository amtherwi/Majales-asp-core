using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Topic.DTO;

namespace Majales.Topic
{
	public interface ITopicAppService : IApplicationService
    {
        IEnumerable<GetTopicOutput> GetAll();
        Task Create(CreateTopicInput input);
        void Update(UpdateTopicInput input);
        void Delete(DeleteTopicInput input);
        GetTopicOutput GetTopicById(GetTopicInput input);


    }
}
