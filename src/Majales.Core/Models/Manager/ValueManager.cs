using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class ValueManager: DomainService, IValueManager
    {
        private readonly IRepository<Value> _repositoryValue;
        public ValueManager(IRepository<Value> repositoryValue)
        {
            _repositoryValue = repositoryValue;
        }
        public async Task<Value> Create(Value entity)
        {
            var value = _repositoryValue.FirstOrDefault(x => x.Id == entity.Id);
            if(value != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryValue.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var value = _repositoryValue.FirstOrDefault(x => x.Id == id);
            if( value == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryValue.Delete(value);
            }       
        }
        public IEnumerable<Value> GetAllList()
        {
            return _repositoryValue.GetAllIncluding( x => x.Classification);
        }

        public Value GetValueByID(int id)
        {
            return _repositoryValue.Get(id);
        }

        public void Update(Value entity)
        {
             _repositoryValue.Update(entity);
        } 
    
    }
}