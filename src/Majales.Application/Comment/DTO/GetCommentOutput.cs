using System;
namespace Majales.Comment.DTO
{
    public class GetCommentOutput
    {
        public int Id { get; set; } 
        public string CommentText { get; set; }
        public int TopicId { get; set; }
        public int MemberId { get; set; }

    }
}
