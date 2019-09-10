using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Majles:FullAuditedEntity
    {
        // [Key]
        // public int id { get; set; }
 
        [Required]
        [Display(Name = "Disaply Name")]
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public string Owner { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        //public DateTime CreationDate { get; set; }  

        
        [ForeignKey("Classification")]
        public int ClassificationId { get; set; }
        public virtual Classification Classification { get; set; }
      
        [Required]
        public bool ActiveStatus { get; set; }
        
        public virtual ICollection<Meeting> Meetings { get; set; }

        public virtual ICollection<MajlisMembership> Membership{get; set;} 
        public Majles(){
            
            Meetings = new Collection<Meeting>();
            Membership = new Collection<MajlisMembership>();
        }
        
    }
}