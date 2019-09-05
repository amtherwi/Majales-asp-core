using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMeetingMinutesManager:IDomainService
    {

        IEnumerable<MeetingMinutes> GetAllList();
        MeetingMinutes GetMeetingMinutesByID(int id);
        Task<MeetingMinutes> Create(MeetingMinutes entity);
        void Update(MeetingMinutes entity);
        void Delete(int id);
      
    }
}