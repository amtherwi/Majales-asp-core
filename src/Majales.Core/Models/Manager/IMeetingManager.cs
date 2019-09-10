using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMeetingManager :IDomainService
    {

        IEnumerable<Meeting> GetAllList();
        Meeting GetMeetingByID(int id);
        Task<Meeting> Create(Meeting entity);
        void Update(Meeting entity);
        void Delete(int id);
      
    }

} 