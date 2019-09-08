using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MeetingAttendanceManager : DomainService, IMeetingAttendanceManager
    {
        private readonly IRepository<MeetingAttendance> _repositoryMeetingAttendance;
        public MeetingAttendanceManager(IRepository<MeetingAttendance> repositoryMeetingAttendance)
        {
            _repositoryMeetingAttendance = repositoryMeetingAttendance;
        }
        public async Task<MeetingAttendance> Create(MeetingAttendance entity)
        {
            var MeetingAttendance = _repositoryMeetingAttendance.FirstOrDefault(x => x.Id == entity.Id);
            if(MeetingAttendance != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMeetingAttendance.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var MeetingAttendance = _repositoryMeetingAttendance.FirstOrDefault(x => x.Id == id);
            if( MeetingAttendance == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMeetingAttendance.Delete(MeetingAttendance);
            }
            
        }

        public IEnumerable<MeetingAttendance> GetAllList()
        {
            return _repositoryMeetingAttendance.GetAll();
        }

        public MeetingAttendance GetMeetingAttendanceByID(int id)
        {
            return _repositoryMeetingAttendance.Get(id);
        }

        public void Update(MeetingAttendance entity)
        {
             _repositoryMeetingAttendance.Update(entity);
        }
    }
 
}