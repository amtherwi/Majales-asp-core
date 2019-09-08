using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.MeetingMinutes.DTO;

namespace Majales.MeetingMinutes
{
    public interface IMeetingMinutesAppService : IApplicationService
    {
        IEnumerable<GetMeetingMinutesOutput> ListAll();
        Task Create(CreateMeetingMinutesInput input);
        void Update(UpdateMeetingMinutesInput input);
        void Delete(DeleteMeetingMinutesInput input);
        GetMeetingMinutesOutput GetMeetingMinutesById(GetMeetingMinutesInput input);
    }
}
