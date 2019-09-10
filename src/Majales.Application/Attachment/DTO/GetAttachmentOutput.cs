using System;
namespace Majales.Attachment.DTO
{
    public class GetAttachmentOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public int TopicId { get; set; }

    }
}
