using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Topic:FullAuditedEntity
    {
       

        [Required]
        [Display(Name = "Title")]
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public bool ActiveStatus { get; set; }

        [ForeignKey("TopicClassification")] 
        public int ClassificationId { get; set; }
        [ForeignKey("Meeting")]
        public int MeetingId { get; set; }
        
        public virtual ICollection<Attachment> Attachments { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Vote> Vote { get; set; }

        public virtual TopicClassification TopicClassification { get; set; }
        public virtual Meeting  Meeting  { get; set; }

       

        public Topic(){
            Attachments = new Collection<Attachment>();
            Comments = new Collection<Comment>();
            Vote = new Collection<Vote>();
        }
        
    }
}