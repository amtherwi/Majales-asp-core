using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MembershipRoleManager: DomainService, IMembershipRoleManager
    {
        private readonly IRepository<MembershipRole> _repositoryMembershipRole;
        public MembershipRoleManager(IRepository<MembershipRole> repositoryMembershipRole)
        {
            _repositoryMembershipRole = repositoryMembershipRole;
        }
        public async Task<MembershipRole> Create(MembershipRole entity)
        {
            var membershipRole = _repositoryMembershipRole.FirstOrDefault(x => x.Id == entity.Id);
            if(membershipRole != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMembershipRole.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var membershipRole = _repositoryMembershipRole.FirstOrDefault(x => x.Id == id);
            if( membershipRole == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMembershipRole.Delete(membershipRole);
            }
            
        }

        public IEnumerable<MembershipRole> GetAllList()
        {
            return _repositoryMembershipRole.GetAll();
        }

        public MembershipRole GetMembershipRoleByID(int id)
        {
            return _repositoryMembershipRole.Get(id);
        }

        public void Update(MembershipRole entity)
        {
             _repositoryMembershipRole.Update(entity);
        }
    }
}