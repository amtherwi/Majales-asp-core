using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IAttachmentManager: IDomainService
    {
        IEnumerable<Attachment> GetAllList();
        Attachment GetAttachmentByID(int id);
        Task<Attachment> Create(Attachment entity);
        void Update(Attachment entity);
        void Delete(int id);
      
         
    }
}