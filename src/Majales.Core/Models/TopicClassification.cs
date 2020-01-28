using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class TopicClassification : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; } 

        [Required]
        public string  Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        public virtual ICollection<Topic> Topic { get; set; }

    }
}