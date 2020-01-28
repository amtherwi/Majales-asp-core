using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Majales.Models
{
    public class VoteTransaction : FullAuditedEntity
    {
        public int VoteValue { get; set; }

        [ForeignKey("Vote")]
        public int VoteId { get; set; }

        [ForeignKey("Member")]
        public int MemberId { get; set; }

        public virtual Vote Vote { get; set; }
        public virtual Member Member { get; set; }
    }
}
