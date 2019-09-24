using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Comment.DTO;
using Majales.Core.Models.Manager;

namespace Majales.Comment
{
    public class CommentAppService : ApplicationService, ICommentAppService
    {
        private readonly ICommentManager _commentManager;
        public CommentAppService(ICommentManager commentManager)
        {
            _commentManager = commentManager;
        }

        public async Task Create(CreateCommentInput input)
        {
            Models.Comment output = Mapper.Map<CreateCommentInput, Models.Comment>(input);
            await _commentManager.Create(output);
        }

        public void Delete(DeleteCommentInput input)
        {
            _commentManager.Delete(input.Id);
        }

        public GetCommentOutput GetCommentById(GetCommentInput input)
        {
            var getComment = _commentManager.GetCommentByID(input.Id);
            GetCommentOutput output = Mapper.Map<Models.Comment, GetCommentOutput>(getComment);
            return output;
        }

        public IEnumerable<GetCommentOutput> GetAll()
        {
            var getAll = _commentManager.GetAllList().ToList();
            List<GetCommentOutput> output = Mapper.Map<List<Models.Comment>, List<GetCommentOutput>>(getAll);
            return output;


        }

        public void Update(UpdateCommentInput input)
        {
            Models.Comment output = Mapper.Map<UpdateCommentInput, Models.Comment>(input);
            _commentManager.Update(output);
        }
    }
}
