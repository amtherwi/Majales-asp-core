using System;
namespace Majales.MeetingAttendance.DTO
{
    public class UpdateMeetingAttendanceInput
    {
        public int Id { get; set; }
        public int Memberid { get; set; }
        public int MeetingId { get; set; }
        public Boolean Attendees { get; set; }
    }
}
