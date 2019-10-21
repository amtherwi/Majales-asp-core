using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Majales.Meeting.DTO;

namespace Majales.Meeting
{
    public interface IMeetingAppSerivce: IApplicationService
    {
        IEnumerable<GetMeetingOutput> GetAll();
        Task Create(CreateMeetingInput input);
        void Update(UpdateMeetingInput input);
        void Delete(DeleteMeetingInput input);
        GetMeetingOutput GetMeetingById(GetMeetingInput input);
    }
}
