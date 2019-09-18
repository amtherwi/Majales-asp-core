using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMajlesTypesManager : IDomainService
    {

        IEnumerable<MajlesTypes> GetAllList();
        MajlesTypes GetMajlesTypesByID(int id);
        Task<MajlesTypes> Create(MajlesTypes entity);
        void Update(MajlesTypes entity);
        void Delete(int id);
      
    }
}