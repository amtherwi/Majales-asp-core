using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class MeetingAttendance : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }

        [ForeignKey("Member")] 
        public int Memberid { get; set; }

        [ForeignKey("Meeting")] 
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; }
        public virtual Member Member{ get; set; }


        public Boolean Attendees { get; set; } 
    

    }
}