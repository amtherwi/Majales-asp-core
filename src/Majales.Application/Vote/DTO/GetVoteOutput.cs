using System;
namespace Majales.Vote.DTO
{
    public class GetVoteOutput
    {

        public int Id { get; set; }
        public string Quesion { get; set; }
        public int TopicId { get; set; }
        public string Answer { get; set; }
        public int MemberId { get; set; }
        public string Notes { get; set; }

    }
}
