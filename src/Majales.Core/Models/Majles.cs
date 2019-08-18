using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;

namespace Majales.Models
{
    public class Majles:FullAuditedEntity
    {
        
        [Required]
        [Display(Name = "Disaply Name")]
        [StringLength(64, ErrorMessage = "Maximum length is 64")]
        public string DisplayName { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        
        
    }
}