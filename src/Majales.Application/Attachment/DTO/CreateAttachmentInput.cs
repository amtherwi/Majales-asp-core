using System;
namespace Majales.Attachment.DTO
{
    public class CreateAttachmentInput
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public int TopicId { get; set; }
        //public DateTime CreationTime { get; set; }

    }
}
