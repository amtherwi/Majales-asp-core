using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMajlesTypeManager : IDomainService
    {

        IEnumerable<MajlesType> GetAllList();
        MajlesType GetMajlesTypeByID(int id);
        MajlesType GetMajlesTypeByType(string type);
        Task<MajlesType> Create(MajlesType entity);
        void Update(MajlesType entity);
        void Delete(int id);
      
    }
}