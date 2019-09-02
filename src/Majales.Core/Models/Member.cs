using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Member : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }
         public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone  { get; set; }
        public string Avatar { get; set; }
        public string NationalId { get; set; }
        public string JobTitle { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string Department { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime EnrolledDate { get; set; }
        public Boolean ActiveStatus { get; set; } 

        public virtual MeetingAttendance MeetingAttendance { get; set; }
        public virtual ICollection<MajlisMembership> membership { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
       public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<MeetingMinutes> meeting_Minutes { get; set; }
        

        public Member()
        {
            membership = new Collection<MajlisMembership>();
            Votes      = new Collection<Vote>();
            Comments   = new Collection<Comment>();
            meeting_Minutes = new Collection<MeetingMinutes>();
        }
        
    }
}