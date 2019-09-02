using System;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class MembershipRole : FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }

        [Required]
        public string Role { get; set; }

        public virtual MajlisMembership MajlisMembership { get; set; }
    
 
    }
}