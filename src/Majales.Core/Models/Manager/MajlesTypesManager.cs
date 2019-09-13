using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MajlesTypesManager: DomainService, IMajlesTypesManager
    {
        private readonly IRepository<MajlesTypes> _repositoryMajlesTypes;
        public MajlesTypesManager(IRepository<MajlesTypes> repositoryMajlesTypes)
        {
            _repositoryMajlesTypes = repositoryMajlesTypes;
        }
        public async Task<MajlesTypes> Create(MajlesTypes entity)
        {
            var MajlesTypes = _repositoryMajlesTypes.FirstOrDefault(x => x.Id == entity.Id);
            if(MajlesTypes != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMajlesTypes.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var MajlesTypes = _repositoryMajlesTypes.FirstOrDefault(x => x.Id == id);
            if( MajlesTypes == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMajlesTypes.Delete(MajlesTypes);
            }       
        }
        public IEnumerable<MajlesTypes> GetAllList()
        {
            return _repositoryMajlesTypes.GetAll();
        }

        public MajlesTypes GetMajlesTypesByID(int id)
        {
            return _repositoryMajlesTypes.Get(id);
        }

        public void Update(MajlesTypes entity)
        {
             _repositoryMajlesTypes.Update(entity);
        } 
    
    }
}