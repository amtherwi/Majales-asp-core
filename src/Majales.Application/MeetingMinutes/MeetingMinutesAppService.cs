using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.MeetingMinutes.DTO;

namespace Majales.MeetingMinutes
{
    public class MeetingMinutesAppService : ApplicationService, IMeetingMinutesAppService
    {
        private readonly IMeetingMinutesManager _meetingMinutesManager;

        public MeetingMinutesAppService(IMeetingMinutesManager meetingMinutesManager)
        {
            _meetingMinutesManager = meetingMinutesManager;
        }
        public IEnumerable<GetMeetingMinutesOutput> GetAll()
        {
            var getAll = _meetingMinutesManager.GetAllList().ToList();
            List<GetMeetingMinutesOutput> output = Mapper.Map<List<Models.MeetingMinutes>, List<GetMeetingMinutesOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMeetingMinutesInput input)
        {
            Models.MeetingMinutes output = Mapper.Map<CreateMeetingMinutesInput, Models.MeetingMinutes>(input);
            await _meetingMinutesManager.Create(output);
        }

        public void Update(UpdateMeetingMinutesInput input)
        {
            Models.MeetingMinutes output = Mapper.Map<UpdateMeetingMinutesInput, Models.MeetingMinutes>(input);
            _meetingMinutesManager.Update(output);
        }

        public void Delete(DeleteMeetingMinutesInput input)
        {
            _meetingMinutesManager.Delete(input.Id);
        }

        public GetMeetingMinutesOutput GetMeetingMinutesById(GetMeetingMinutesInput input)
        {
            var getMeetingMinutes = _meetingMinutesManager.GetMeetingMinutesByID(input.Id);
            GetMeetingMinutesOutput output = Mapper.Map<Models.MeetingMinutes, GetMeetingMinutesOutput>(getMeetingMinutes);
            return output;
        }
    }
}
