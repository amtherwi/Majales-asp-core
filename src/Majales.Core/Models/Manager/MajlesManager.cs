
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;
using Microsoft.EntityFrameworkCore;

namespace Majales.Core.Models.Manager
{
    public class MajlesManager: DomainService, IMajlesManager
    {
        private readonly IRepository<Majles> _repositoryMajles;
        public MajlesManager(IRepository<Majles> repositoryMajles)
        {
            _repositoryMajles = repositoryMajles;
        }
        public async Task<Majles> Create(Majles entity)
        {
            var majles = _repositoryMajles.FirstOrDefault(x => x.Id == entity.Id);
            if(majles != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMajles.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var majles = _repositoryMajles.FirstOrDefault(x => x.Id == id);
            if( majles == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMajles.Delete(majles);
            }
            
        }

        public IEnumerable<Majles> GetAllList()
        {

            return _repositoryMajles.GetAllIncluding(x => x.MajlesType);
                  //.GetAll()
                  //.Include(type => type.MajlesType)
                  //.ToList();
                  
        }

        public Majles GetMajlesByID(int id)
        {
            IEnumerable<Majles> majales = _repositoryMajles.GetAllIncluding(x => x.MajlesType);
            return majales.First(c => c.Id == id);
        }

        public void Update(Majles entity)
        {
             _repositoryMajles.Update(entity);
        }
    }
}