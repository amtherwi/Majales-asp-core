using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MeetingAttendance.DTO;

namespace Majales.MeetingAttendance
{
    public interface IMeetingAttendanceAppService: IApplicationService
    {
        IEnumerable<GetMeetingAttendanceOutput> GetAll();
        Task Create(CreateMeetingAttendanceInput input);
        void Update(UpdateMeetingAttendanceInput input);
        void Delete(DeleteMeetingAttendanceInput input);
        GetMeetingAttendanceOutput GetMeetingAttendanceById(GetMeetingAttendanceInput input);
    }
}
