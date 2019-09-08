using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Comment.DTO;

namespace Majales.Comment
{
    public interface ICommentAppService:IApplicationService
    {
        IEnumerable<GetCommentOutput> ListAll();
        GetCommentOutput GetCommentById(GetCommentInput input);
        Task Create(CreateCommentInput input);
        void Update(UpdateCommentInput input);
        void Delete(DeleteCommentInput input);
    }
}
