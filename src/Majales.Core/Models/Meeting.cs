using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Meeting:FullAuditedEntity
    {
       

        [Required]
        [Display(Name = "Title")]
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        [ForeignKey("Majles")]
        public int MajlesId { get; set; }



        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime MeetingDate { get; set; }  

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        public DateTime MeetingTime { get; set; }  
        
        public string  Location { get; set; }
            
        [Required]
        public bool ActiveStatus { get; set; }
        
        public virtual Majles Majles { get; set; } 
 
        public virtual ICollection<Topic> Topics{get; set;} 
        public virtual ICollection<MeetingAttendance> MeetingAttendance { get; set; }

        public Meeting()
        {
            
            Topics = new Collection<Topic>();
            MeetingAttendance=new Collection<MeetingAttendance>();
        }

        
        
    }
}