using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Value : FullAuditedEntity
    {

        public virtual Classification Classification { get; set; }

        public int CEO_inCost { get; set; }
        public int CEO_outCost { get; set; }

        public int Sec_inCost { get; set; } 
        public int Sec_outCost { get; set; }
        public int MSec_inCost { get; set; }
        public int MSec_outCost { get; set; }
        public int Mem_inCost { get; set; }
        public int Mem_outCost { get; set; }
        
        public Value()
        {
        }
        
    }
}