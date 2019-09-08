using System;
namespace Majales.Meeting.DTO
{
    public class CreateMeetingInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int CEOid { get; set; }
        public DateTime Date { get; set; }
        public DateTime MeetingTime { get; set; }
        public string Location { get; set; }
        public bool ActiveStatus { get; set; }
        //public DateTime CreationTime { get; set; }
    }
}
