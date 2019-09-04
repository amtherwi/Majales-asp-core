using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MajlisMembershipManager: DomainService, IMajlisMembershipManager
    {
        private readonly IRepository<MajlisMembership> _repositoryMajlisMembership;
        public MajlisMembershipManager(IRepository<MajlisMembership> repositoryMajlisMembership)
        {
            _repositoryMajlisMembership = repositoryMajlisMembership;
        }
        public async Task<MajlisMembership> Create(MajlisMembership entity)
        {
            var MajlisMembership = _repositoryMajlisMembership.FirstOrDefault(x => x.Id == entity.Id);
            if(MajlisMembership != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMajlisMembership.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var majlisMembership = _repositoryMajlisMembership.FirstOrDefault(x => x.Id == id);
            if( majlisMembership == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMajlisMembership.Delete(majlisMembership);
            }
            
        }

        public IEnumerable<MajlisMembership> GetAllList()
        {
            return _repositoryMajlisMembership.GetAllIncluding(x => x.Members);
        }

        public MajlisMembership GetMajlisMembershipByID(int id)
        {
            return _repositoryMajlisMembership.Get(id);
        }

        public void Update(MajlisMembership entity)
        {
             _repositoryMajlisMembership.Update(entity);
        } 
    
    }
}