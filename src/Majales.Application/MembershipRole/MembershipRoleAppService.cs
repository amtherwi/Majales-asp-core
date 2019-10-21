using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.MembershipRole.DTO;

namespace Majales.MembershipRole
{
    public class MembershipRoleAppService : ApplicationService, IMembershipRoleAppService
    {
        private readonly IMembershipRoleManager _membershipRoleManager;

        public MembershipRoleAppService(IMembershipRoleManager membershipRoleManager)
        {
            _membershipRoleManager = membershipRoleManager;
        }
        public IEnumerable<GetMembershipRoleOutput> GetAll()
        {
            var getAll = _membershipRoleManager.GetAllList().ToList();
            List<GetMembershipRoleOutput> output = Mapper.Map<List<Models.MembershipRole>, List<GetMembershipRoleOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMembershipRoleInput input)
        {
            Models.MembershipRole output = Mapper.Map<CreateMembershipRoleInput, Models.MembershipRole>(input);
            await _membershipRoleManager.Create(output);
        }

        public void Update(UpdateMembershipRoleInput input)
        {
            Models.MembershipRole output = Mapper.Map<UpdateMembershipRoleInput, Models.MembershipRole>(input);
            _membershipRoleManager.Update(output);
        }

        public void Delete(DeleteMembershipRoleInput input)
        {
            _membershipRoleManager.Delete(input.Id);
        }

        public GetMembershipRoleOutput GetMembershipRoleById(GetMembershipRoleInput input)
        {
            var getMembershipRole = _membershipRoleManager.GetMembershipRoleByID(input.Id);
            GetMembershipRoleOutput output = Mapper.Map<Models.MembershipRole, GetMembershipRoleOutput>(getMembershipRole);
            return output;
        }
    }
}
