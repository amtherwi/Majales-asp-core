using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MemberManager: DomainService, IMemberManager
    {
        private readonly IRepository<Member> _repositoryMember;
        public MemberManager(IRepository<Member> repositoryMember)
        {
            _repositoryMember = repositoryMember;
        }
        public async Task<Member> Create(Member entity)
        {
            var member = _repositoryMember.FirstOrDefault(x => x.Id == entity.Id);
            if(member != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMember.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var member = _repositoryMember.FirstOrDefault(x => x.Id == id);
            if( member == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMember.Delete(member);
            }
            
        }

        public IEnumerable<Member> GetAllList()
        {
            return _repositoryMember.GetAllIncluding(x => x.membership);
        }

        public Member GetMemberByID(int id)
        {
            return _repositoryMember.Get(id);
        }

        public void Update(Member entity)
        {
             _repositoryMember.Update(entity);
        } 
    
    }
}