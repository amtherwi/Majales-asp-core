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

        [ForeignKey("MajlesTypes")] 
        public int MajlesTypeId { get; set; }
        public virtual MajlesType MajlesType { get; set; }

        public int CEO_inCost { get; set; }
        public int CEO_outCost { get; set; }

        public int Sec_inCost { get; set; } 
        public int Sec_outCost { get; set; }
        public int MSec_inCost { get; set; }
        public int MSec_outCost { get; set; }
        public int Mem_inCost { get; set; }
        public int Mem_outCost { get; set; }
        
        // public virtual ICollection<Classification> Classifications { get; set; }

        public Classification()
        {
            // Classifications = new Collection<Classification>(); 
        }
        
    }
}