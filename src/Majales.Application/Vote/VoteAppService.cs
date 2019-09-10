using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Vote.DTO;

namespace Majales.Vote
{
    public class VoteAppService : ApplicationService, IVoteAppService
    {
        private readonly IVoteManager _voteManager;

        public VoteAppService(IVoteManager voteManager)
        {
            _voteManager = voteManager;
        }
        public IEnumerable<GetVoteOutput> ListAll()
        {
            var getAll = _voteManager.GetAllList().ToList();
            List<GetVoteOutput> output = Mapper.Map<List<Models.Vote>, List<GetVoteOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateVoteInput input)
        {
            Models.Vote output = Mapper.Map<CreateVoteInput, Models.Vote>(input);
            await _voteManager.Create(output);
        }

        public void Update(UpdateVoteInput input)
        {
            Models.Vote output = Mapper.Map<UpdateVoteInput, Models.Vote>(input);
            _voteManager.Update(output);
        }

        public void Delete(DeleteVoteInput input)
        {
            _voteManager.Delete(input.Id);
        }

        public GetVoteOutput GetVoteById(GetVoteInput input)
        {
            var getVote = _voteManager.GetVoteByID(input.Id);
            GetVoteOutput output = Mapper.Map<Models.Vote, GetVoteOutput>(getVote);
            return output;
        }
    }
}
