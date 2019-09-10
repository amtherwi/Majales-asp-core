using System;
namespace Majales.Topic.DTO
{
    public class UpdateTopicInput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ClassificationId { get; set; }
        public int MeetingId { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
