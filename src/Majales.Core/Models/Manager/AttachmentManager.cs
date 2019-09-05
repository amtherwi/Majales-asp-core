using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class AttachmentManager: DomainService, IAttachmentManager
    {
        private readonly IRepository<Attachment> _repositoryAttachment;
        public AttachmentManager(IRepository<Attachment> repositoryAttachment)
        {
            _repositoryAttachment = repositoryAttachment;
        }

        public async Task<Attachment> Create(Attachment entity)
        {
             var attachment = _repositoryAttachment.FirstOrDefault(x => x.Id == entity.Id);
            if(attachment != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryAttachment.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var attachment = _repositoryAttachment.FirstOrDefault(x => x.Id == id);
            if( attachment == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryAttachment.Delete(attachment);
            }
        }

        public IEnumerable<Attachment> GetAllList()
        {
            return _repositoryAttachment.GetAllIncluding(x => x.Topic);
        }

        public Attachment GetAttachmentByID(int id)
        {
            return _repositoryAttachment.Get(id);
        }

        public void Update(Attachment entity)
        {
            _repositoryAttachment.Update(entity);
        }
    }
}