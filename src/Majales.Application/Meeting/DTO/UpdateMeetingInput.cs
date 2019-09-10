using System;
namespace Majales.Meeting.DTO
{
    public class UpdateMeetingInput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public int CEOid { get; set; }
        public DateTime Date { get; set; }
        public DateTime MeetingTime { get; set; }
        public string Location { get; set; }
        public bool ActiveStatus { get; set; }

    }
}
