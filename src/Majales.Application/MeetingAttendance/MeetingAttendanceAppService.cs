using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.MeetingAttendance.DTO;

namespace Majales.MeetingAttendance
{
    public class MeetingAttendanceAppService : ApplicationService, IMeetingAttendanceAppService
    {
        private readonly IMeetingAttendanceManager _meetingAttendancManager;

        public MeetingAttendanceAppService(IMeetingAttendanceManager meetingAttendancManager)
        {
            _meetingAttendancManager = meetingAttendancManager;
        }

        public IEnumerable<GetMeetingAttendanceOutput> GetAll()
        {
            var getAll = _meetingAttendancManager.GetAllList().ToList();
            List<GetMeetingAttendanceOutput> output = Mapper.Map<List<Models.MeetingAttendance>, List<GetMeetingAttendanceOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMeetingAttendanceInput input)
        {
            Models.MeetingAttendance output = Mapper.Map<CreateMeetingAttendanceInput, Models.MeetingAttendance>(input);
            await _meetingAttendancManager.Create(output);
        }

        public void Update(UpdateMeetingAttendanceInput input)
        {
            Models.MeetingAttendance output = Mapper.Map<UpdateMeetingAttendanceInput, Models.MeetingAttendance>(input);
            _meetingAttendancManager.Update(output);
        }

        public void Delete(DeleteMeetingAttendanceInput input)
        {
            _meetingAttendancManager.Delete(input.Id);
        }

        public GetMeetingAttendanceOutput GetMeetingAttendanceById(GetMeetingAttendanceInput input)
        {
            var getMeetingAttendance = _meetingAttendancManager.GetMeetingAttendanceByID(input.Id);
            GetMeetingAttendanceOutput output = Mapper.Map<Models.MeetingAttendance, GetMeetingAttendanceOutput>(getMeetingAttendance);
            return output;
        }
    }
}
