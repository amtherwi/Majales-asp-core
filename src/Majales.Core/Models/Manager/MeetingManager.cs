using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Majales.Models;

namespace Majales.Core.Models.Manager
{
    public class MeetingManager : DomainService, IMeetingManager
    {
        private readonly IRepository<Meeting> _repositoryMeeting;
        public MeetingManager(IRepository<Meeting> repositoryMeeting)
        {
            _repositoryMeeting = repositoryMeeting;
        }
        public async Task<Meeting> Create(Meeting entity)
        {
            var Meeting = _repositoryMeeting.FirstOrDefault(x => x.Id == entity.Id);
            if(Meeting != null){
                throw new UserFriendlyException("Already Exist");
            
            } else
            {
                return await _repositoryMeeting.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var Meeting = _repositoryMeeting.FirstOrDefault(x => x.Id == id);
            if( Meeting == null ) {

                throw new UserFriendlyException("No Data Found");

            } else{

                _repositoryMeeting.Delete(Meeting);
            }
            
        }

        public IEnumerable<Meeting> GetAllList()
        {
            return _repositoryMeeting.GetAll();
        }

        public Meeting GetMeetingByID(int id)
        {
            return _repositoryMeeting.Get(id);
        }

        public void Update(Meeting entity)
        {
             _repositoryMeeting.Update(entity);
        }
    }
}