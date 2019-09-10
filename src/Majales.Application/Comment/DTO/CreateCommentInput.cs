using System;
namespace Majales.Comment.DTO
{
    public class CreateCommentInput
    {
        public string CommentText { get; set; }
        public int TopicId { get; set; }
        public int MemberId { get; set; }
    }
}
