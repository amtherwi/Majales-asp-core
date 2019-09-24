using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Attachment.DTO;

namespace Majales.Attachment
{
    public interface IAttachmentAppService : IApplicationService
    {
        IEnumerable<GetAttachmentOutput> GetAll();
        Task Create(CreateAttachmentInput input);
        void Update(UpdateAttachmentInput input);
        void Delete(DeleteAttachmentInput input);
        GetAttachmentOutput GetAttachmentById(GetAttachmentInput input);
    }
}
