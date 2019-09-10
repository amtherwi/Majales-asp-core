using System;
namespace Majales.MeetingMinutes.DTO
{
    public class UpdateMeetingMinutesInput
    {
        public int Id { get; set; }
        public int TopicId { get; set; }
        public string Descussion { get; set; }
        public string Decision { get; set; }
    }
}
