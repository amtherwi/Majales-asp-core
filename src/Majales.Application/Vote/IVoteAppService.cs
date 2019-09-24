using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Vote.DTO;

namespace Majales.Vote
{
    public interface IVoteAppService : IApplicationService
    {
        IEnumerable<GetVoteOutput> GetAll();
        Task Create(CreateVoteInput input);
        void Update(UpdateVoteInput input);
        void Delete(DeleteVoteInput input);
        GetVoteOutput GetVoteById(GetVoteInput input);

    }
}

