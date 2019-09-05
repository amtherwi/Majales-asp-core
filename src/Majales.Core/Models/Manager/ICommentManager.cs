using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface ICommentManager : IDomainService
    {

        IEnumerable<Comment> GetAllList();
        Comment GetCommentByID(int id);
        Task<Comment> Create(Comment entity);
        void Update(Comment entity);
        void Delete(int id);
     
    }
}