using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class CommentManager: DomainService, ICommentManager
    {
        private readonly IRepository<Comment> _repositoryComment;
        public CommentManager(IRepository<Comment> repositoryComment)
        {
            _repositoryComment = repositoryComment;
        }
        public async Task<Comment> Create(Comment entity)
        {
            var comment = _repositoryComment.FirstOrDefault(x => x.Id == entity.Id);
            if(comment != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryComment.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var comment = _repositoryComment.FirstOrDefault(x => x.Id == id);
            if( comment == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryComment.Delete(comment);
            }
            
        }

        public IEnumerable<Comment> GetAllList()
        {
            return _repositoryComment.GetAllIncluding(x => x.Topic);
        }

        public Comment GetCommentByID(int id)
        {
            return _repositoryComment.Get(id);
        }

        public void Update(Comment entity)
        {
             _repositoryComment.Update(entity);
        } 
    
    }
}