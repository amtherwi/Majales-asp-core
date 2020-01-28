using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Majales.Models
{
   public class Value: FullAuditedEntity
    {
        public Value()
        {
            Classifications = new Collection<Classification>();
        }
        public float? CEOinCost { get; set; }
        public float? CEOoutCost { get; set; }

        public float? SecinCost { get; set; }
        public float? SecoutCost { get; set; }

        public float? MSecinCost { get; set; }
        public float? MSecoutCost { get; set; }

        public float? MeminCost { get; set; }
        public float? MemoutCost { get; set; }
        public virtual ICollection<Classification> Classifications { get; set; }

    }
}
