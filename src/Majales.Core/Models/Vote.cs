using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Vote : FullAuditedEntity
    {
       
        [Required]
        public string Quesion { get; set; }
        public string Answer { get; set; }
        public string Notes { get; set; }
        public int YesResult { get; set; }
        public int NoResult { get; set; }
        public int abstentResult { get; set; }

        [ForeignKey("Topic")]
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }

        public virtual ICollection<VoteTransaction> VoteTransaction { get; set; }

    }
}