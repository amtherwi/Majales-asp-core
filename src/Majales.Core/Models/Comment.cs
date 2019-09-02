using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Comment : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }
        public string comment { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        
        public virtual Topic Topic { get; set; }
 
        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public virtual Member Member { get; set; }


    }
}