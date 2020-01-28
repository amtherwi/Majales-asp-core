using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Classification : FullAuditedEntity
    {

        [ForeignKey("MajlesType")]
        public int MajlesTypeId { get; set; }

        [ForeignKey("Value")]
        public int ValueId { get; set; }

        public string ClassificationType { get; set; }
       
        public virtual MajlesType MajlesType { get; set; }
        public virtual Value Value { get; set; }
    }
}