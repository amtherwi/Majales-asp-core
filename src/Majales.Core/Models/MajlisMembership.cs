using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class MajlisMembership : FullAuditedEntity
    {
       

        [ForeignKey("Majles")]
        public int MajlesId {get; set;} 

        [ForeignKey("Member")]
        public int MemberId { get; set; } 

        [ForeignKey("MembershipRole")]
        public int RoleId {get; set;}

        public virtual Majles Majles { get; set; }
        public virtual Member Members { get; set; } 
        public virtual MembershipRole MembershipRole {get; set;}


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime JoinDate { get; set; }
       

    }
}