using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Majales.Authorization.Users;

namespace Majales.Models
{
    public class Member : FullAuditedEntity
    {
        public string MemberName { get; set; }
        public string MemberEmail { get; set;}
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public string NationalId { get; set; }
        
        public string JobTitle { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string Department { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrolledDate { get; set; }
        public bool ActiveStatus { get; set; }
        public virtual MeetingAttendance MeetingAttendance { get; set; }
        public virtual ICollection<MajlisMembership> membership { get; set; }
        public virtual ICollection<VoteTransaction> VoteTransaction { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<MeetingMinutes> meeting_Minutes { get; set; }
        
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }


        public Member()
        {
            membership = new Collection<MajlisMembership>();
            VoteTransaction = new Collection<VoteTransaction>();
            Comments   = new Collection<Comment>();
            meeting_Minutes = new Collection<MeetingMinutes>();
        }
        
    }
}