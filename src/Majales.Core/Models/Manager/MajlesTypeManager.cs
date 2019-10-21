using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MajlesTypeManager: DomainService, IMajlesTypeManager
    {
        private readonly IRepository<MajlesType> _repositoryMajlesType;
        public MajlesTypeManager(IRepository<MajlesType> repositoryMajlesType)
        {
            _repositoryMajlesType = repositoryMajlesType;
        }
        public async Task<MajlesType> Create(MajlesType entity)
        {
            var MajlesType = _repositoryMajlesType.FirstOrDefault(x => x.Id == entity.Id);
            if(MajlesType != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMajlesType.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var MajlesType = _repositoryMajlesType.FirstOrDefault(x => x.Id == id);
            if( MajlesType == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMajlesType.Delete(MajlesType);
            }       
        }
        public IEnumerable<MajlesType> GetAllList()
        {
            return _repositoryMajlesType.GetAll();
        }

        public MajlesType GetMajlesTypeByID(int id)
        {
            return _repositoryMajlesType.Get(id);
        }

        public void Update(MajlesType entity)
        {
             _repositoryMajlesType.Update(entity);
        } 
    
    }
}