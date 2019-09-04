using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class TopicClassificationManager : DomainService, ITopicClassificationManager
    {
        private readonly IRepository<TopicClassification> _repositoryTopicClassification; 
        public TopicClassificationManager(IRepository<TopicClassification> repositoryTopicClassification){

            _repositoryTopicClassification = repositoryTopicClassification;
        }

        public async Task<TopicClassification> Create(TopicClassification entity)
        {
            var topicClassification = _repositoryTopicClassification.FirstOrDefault(x => x.Id == entity.Id);
            if(topicClassification != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryTopicClassification.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var topicClassification = _repositoryTopicClassification.FirstOrDefault(x => x.Id == id);
            if( topicClassification == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryTopicClassification.Delete(topicClassification);
            }
            
        }

        public IEnumerable<TopicClassification> GetAllList()
        {
            return _repositoryTopicClassification.GetAll();
        }

        public TopicClassification GetTopicClassificationByID(int id)
        {
            return _repositoryTopicClassification.Get(id);
        }

        public void Update(TopicClassification entity)
        {
             _repositoryTopicClassification.Update(entity);
        } 
    
    }
}