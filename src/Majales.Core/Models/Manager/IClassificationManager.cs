using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IClassificationManager: IDomainService
    {

        IEnumerable<Classification> GetAllList();
        Classification GetClassificationByID(int id);
        Task<Classification> Create(Classification entity);
        void Update(Classification entity);
        void Delete(int id);
      
    
         
    }
}