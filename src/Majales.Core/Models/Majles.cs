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
        [Required]
        [Display(Name = "Disaply Name")]
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [ForeignKey("MajlesType")]
        public int MajlesTypeId { get; set; }

        [Required]
        [ForeignKey("Classification")]
        public int ClassificationId { get; set; }
        [ForeignKey("ParentMajles")]
        public int? ParentMajlesId { get; set; }
        public virtual MajlesType MajlesType { get; set; }

        public virtual Classification Classification { get; set; }
        public virtual Majles ParentMajles { get; set; }
        [Required]
        public bool ActiveStatus { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }

        public virtual ICollection<MajlisMembership> Membership { get; set; }

        public virtual ICollection<Majles> ChiledMajles { get; set; }

        public Majles()
        {

            Meetings = new Collection<Meeting>();
            Membership = new Collection<MajlisMembership>();
        }

    }
}