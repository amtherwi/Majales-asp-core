using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Majales.Models;
namespace Majales.Majles.DTO
{
     [AutoMapFrom(typeof(Models.Majles))]
    public class MajlesDto : EntityDto<int> 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public Models.Classification Classification { get; set; }
        public bool ActiveStatus { get; set; }
        //public DateTime CreationTime { get; set; }
        
    }
}