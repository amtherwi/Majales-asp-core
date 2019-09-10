using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public interface IMeetingAttendanceManager : IDomainService
    {

        IEnumerable<MeetingAttendance> GetAllList();
        MeetingAttendance GetMeetingAttendanceByID(int id);
        Task<MeetingAttendance> Create(MeetingAttendance entity);
        void Update(MeetingAttendance entity);
        void Delete(int id);
      
    }
   
}