using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Attachment.DTO;
using Majales.Core.Models.Manager;

namespace Majales.Attachment
{
    public class AttachmentAppService: ApplicationService, IAttachmentAppService
    {
        private readonly IAttachmentManager _attachmentManager;

        public AttachmentAppService(IAttachmentManager attachmentManager)
        {
            _attachmentManager = attachmentManager;
        }

        public IEnumerable<GetAttachmentOutput> GetAll()
        {
            var getAll = _attachmentManager.GetAllList().ToList();
            List<GetAttachmentOutput> output = Mapper.Map<List<Models.Attachment>, List<GetAttachmentOutput>>(getAll);
            return output;

        }

        public async Task Create(CreateAttachmentInput input)
        {
            Models.Attachment output = Mapper.Map<CreateAttachmentInput, Models.Attachment>(input);
            await _attachmentManager.Create(output);
        }

        public void Delete(DeleteAttachmentInput input)
        {
            _attachmentManager.Delete(input.Id);
        }

        public GetAttachmentOutput GetAttachmentById(GetAttachmentInput input)
        {
            var getAttachment = _attachmentManager.GetAttachmentByID(input.Id);
            GetAttachmentOutput output = Mapper.Map<Models.Attachment, GetAttachmentOutput>(getAttachment);
            return output;

        }

        public void Update(UpdateAttachmentInput input)
        {
            Models.Attachment output = Mapper.Map<UpdateAttachmentInput, Models.Attachment>(input);
            _attachmentManager.Update(output);
        }
    }
}
