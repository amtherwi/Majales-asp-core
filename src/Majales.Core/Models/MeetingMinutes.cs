using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace Majales.Models
{
    public class MeetingMinutes : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }

        // [ForeignKey("Meeting"), Column(Order = 0)]
        // public int MeetingId { get; set; }

        [ForeignKey("Topic"), Column(Order = 1)]
        public int TopicId { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public string Descussion { get; set; }
        public string Decision { get; set; }
        
        // public virtual Meeting Meeting { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual Member Member { get; set; }
    }
}