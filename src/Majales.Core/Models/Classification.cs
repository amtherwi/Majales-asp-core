using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Classification : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }
        public string Type { get; set; }
        
        [ForeignKey("Value")] 
        public int ValueId { get; set; }
        public virtual Value Value { get; set; }

        public virtual Majles Majles { get; set; }

    }
}