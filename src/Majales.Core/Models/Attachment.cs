using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Attachment : FullAuditedEntity
    { 
        // [Key]
        // public int id { get; set; }
        
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string Name { get; set; }
        
        [StringLength(200)]
        public string ContentType { get; set; }
        
        public byte[] Data { get; set; } 

        [ForeignKey("Topic")] 
        public int TopicId { get; set; } 
        public virtual Topic Topic { get; set; } 


        public Attachment()
        {
        }
        
    }
}