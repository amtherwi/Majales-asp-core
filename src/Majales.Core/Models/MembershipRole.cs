using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class MembershipRole : FullAuditedEntity
    {
        

        [Required]
        public string Role { get; set; }

        public virtual ICollection<MajlisMembership> MajlisMembership { get; set; }
    
 
    }
}