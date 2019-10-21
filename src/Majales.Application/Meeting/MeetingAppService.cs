using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using AutoMapper;
using Majales.Core.Models.Manager;
using Majales.Meeting.DTO;

namespace Majales.Meeting
{
    public class MeetingAppService : ApplicationService,IMeetingAppSerivce 
    {
        private readonly IMeetingManager _meetingManager;

        public MeetingAppService(IMeetingManager meetingManager)
        {
            _meetingManager = meetingManager;
        }
        public IEnumerable<GetMeetingOutput> GetAll()
        {
            var getAll = _meetingManager.GetAllList().ToList();
            List<GetMeetingOutput> output = Mapper.Map<List<Models.Meeting>, List<GetMeetingOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateMeetingInput input)
        {
            Models.Meeting output = Mapper.Map<CreateMeetingInput, Models.Meeting>(input);
            await _meetingManager.Create(output);
        }

        public void Update(UpdateMeetingInput input)
        {
            Models.Meeting output = Mapper.Map<UpdateMeetingInput, Models.Meeting>(input);
            _meetingManager.Update(output);
        }

        public void Delete(DeleteMeetingInput input)
        {
            _meetingManager.Delete(input.Id);
        }

        public GetMeetingOutput GetMeetingById(GetMeetingInput input)
        {
            var getMeeting = _meetingManager.GetMeetingByID(input.Id);
            GetMeetingOutput output = Mapper.Map<Models.Meeting, GetMeetingOutput>(getMeeting);
            return output;
        }
    }
}
