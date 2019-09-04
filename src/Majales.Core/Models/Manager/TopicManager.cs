using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class TopicManager : DomainService, ITopicManager
    {
        private readonly IRepository<Topic> _repositoryTopic;
        public TopicManager(IRepository<Topic> repositoryTopic)
        {
            _repositoryTopic = repositoryTopic;
        }
        public async Task<Topic> Create(Topic entity)
        {
            var topic = _repositoryTopic.FirstOrDefault(x => x.Id == entity.Id);
            if(topic != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryTopic.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var topic = _repositoryTopic.FirstOrDefault(x => x.Id == id);
            if( topic == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryTopic.Delete(topic);
            }
            
        }

        public IEnumerable<Topic> GetAllList()
        {
            return _repositoryTopic.GetAllIncluding(x => x.Meeting);
        }

        public Topic GetTopicByID(int id)
        {
            return _repositoryTopic.Get(id);
        }

        public void Update(Topic entity)
        {
             _repositoryTopic.Update(entity);
        } 
    
    }
}