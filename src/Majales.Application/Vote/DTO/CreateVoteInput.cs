using System;
namespace Majales.Vote.DTO
{
    public class CreateVoteInput
    {
        public string Quesion { get; set; }
        public int TopicId { get; set; }
        public string Answer { get; set; }
        public int MemberId { get; set; }
        public string Notes { get; set; }
    }
}
