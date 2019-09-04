using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MeetingMinutesManager: DomainService, IMeetingMinutesManager
    {
        private readonly IRepository<MeetingMinutes> _repositoryMeetingMinutes;
        public MeetingMinutesManager(IRepository<MeetingMinutes> repositoryMeetingMinutes)
        {
            _repositoryMeetingMinutes = repositoryMeetingMinutes;
        }
        public async Task<MeetingMinutes> Create(MeetingMinutes entity)
        {
            var meetingMinutes = _repositoryMeetingMinutes.FirstOrDefault(x => x.Id == entity.Id);
            if(meetingMinutes != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMeetingMinutes.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var meetingMinutes = _repositoryMeetingMinutes.FirstOrDefault(x => x.Id == id);
            if( meetingMinutes == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMeetingMinutes.Delete(meetingMinutes);
            }
            
        }

        public IEnumerable<MeetingMinutes> GetAllList()
        {
            return _repositoryMeetingMinutes.GetAllIncluding(x => x.Topic);
        }

        public MeetingMinutes GetMeetingMinutesByID(int id)
        {
            return _repositoryMeetingMinutes.Get(id);
        }

        public void Update(MeetingMinutes entity)
        {
             _repositoryMeetingMinutes.Update(entity);
        } 
    
    }
}