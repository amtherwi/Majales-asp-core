using System;

namespace Majales.Majles.DTO
{
    public class CreateMajlesInput
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public int ClassificationId { get; set; }
        public bool ActiveStatus { get; set; }
        //public DateTime CreationTime { get; set; }

    }
}