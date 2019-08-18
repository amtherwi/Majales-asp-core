using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;

namespace Majales.Models
{
    public class MajlesManager:DomainService,IMajlesManager
    {
        private readonly IRepository<Majles> _repositoryMajles;

        public MajlesManager(IRepository<Majles> repositoryMajles)
        {
            _repositoryMajles = repositoryMajles;
        }
        
        public IEnumerable<Majles> GetAllList()
        {
            return _repositoryMajles.GetAllIncluding();
        }

        public Majles GetMajlesByID(int id)
        {
            return _repositoryMajles.Get(id);
        }

        public async Task<Majles> create(Majles entity)
        {
            var majles = _repositoryMajles.FirstOrDefault(x => x.Id == entity.Id);
            if (majles != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {
                return await _repositoryMajles.InsertAsync(entity);    
            }
            
        }

        public void update(Majles entity)
        {
            _repositoryMajles.Update(entity);
        }

        public void delete(int id)
        {
            var majles = _repositoryMajles.FirstOrDefault(x => x.Id == id);
            if (majles != null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryMajles.Delete(majles);
            }
        }
    }
}