using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Vote : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }

        [Required]
        public string Quesion { get; set; }

        [ForeignKey("Topic")] 
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }


        public string Answer { get; set; }

        [ForeignKey("Member")] 
        public int MemberId { get; set; }
        public virtual Member Members { get; set; }


        public string Notes { get; set; }

    }
}