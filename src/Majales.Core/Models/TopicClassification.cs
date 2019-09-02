using System;
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

        public virtual Topic Topic { get; set; }
        public TopicClassification()
        {
        }
        
    }
}