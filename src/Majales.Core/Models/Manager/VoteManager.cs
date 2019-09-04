using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class VoteManager : DomainService, IVoteManager
    {
        private readonly IRepository<Vote> _repositoryVote;
        public VoteManager(IRepository<Vote> repositoryVote)
        {
            _repositoryVote = repositoryVote;
        }
        public async Task<Vote> Create(Vote entity)
        {
            var vote = _repositoryVote.FirstOrDefault(x => x.Id == entity.Id);
            if(vote != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryVote.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var vote = _repositoryVote.FirstOrDefault(x => x.Id == id);
            if( vote == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryVote.Delete(vote);
            }
            
        }

        public IEnumerable<Vote> GetAllList()
        {
            return _repositoryVote.GetAllIncluding( x => x.Topic);
        }

        public Vote GetVoteByID(int id)
        {
            return _repositoryVote.Get(id);
        }

        public void Update(Vote entity)
        {
             _repositoryVote.Update(entity);
        } 
    
    }
}