using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class MajlesType : FullAuditedEntity
    {
  
        public string Type { get; set; }
        
        //public virtual Classification Classification { get; set; }

        //public virtual Majles Majles { get; set; }


    }
}