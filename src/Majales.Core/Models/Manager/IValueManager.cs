using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IValueManager : IDomainService
    {

        IEnumerable<Value> GetAllList();
        Value GetValueByID(int id);
        Task<Value> Create(Value entity);
        void Update(Value entity);
        void Delete(int id);
      
    }
}