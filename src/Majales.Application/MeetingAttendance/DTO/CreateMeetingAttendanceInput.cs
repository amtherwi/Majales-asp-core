using System;
namespace Majales.MeetingAttendance.DTO
{
    public class CreateMeetingAttendanceInput
    {
        public int Memberid { get; set; }
        public int MeetingId { get; set; }
        public Boolean Attendees { get; set; }
    }
    
}
