using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Member.DTO;

namespace Majales.Member
{
    public class MemberAppService : ApplicationService, IMemberAppService
    {
        private readonly IMemberManager _memberManager;

        public MemberAppService(IMemberManager memberManager)
        {
            _memberManager = memberManager;
        }
        public IEnumerable<GetMemberOutput> ListAll()
        {
            var getAll = _memberManager.GetAllList().ToList();
            List<GetMemberOutput> output = Mapper.Map<List<Models.Member>, List<GetMemberOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMemberInput input)
        {
            Models.Member output = Mapper.Map<CreateMemberInput, Models.Member>(input);
            await _memberManager.Create(output);
        }

        public void Update(UpdateMemberInput input)
        {
            Models.Member output = Mapper.Map<UpdateMemberInput, Models.Member>(input);
            _memberManager.Update(output);
        }

        public void Delete(DeleteMemberInput input)
        {
            _memberManager.Delete(input.Id);
        }

        public GetMemberOutput GetMemberById(GetMemberInput input)
        {
            var getMember = _memberManager.GetMemberByID(input.Id);
            GetMemberOutput output = Mapper.Map<Models.Member, GetMemberOutput>(getMember);
            return output;
        }
    }
}
