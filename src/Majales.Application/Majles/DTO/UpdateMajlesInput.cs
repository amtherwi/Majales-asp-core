namespace Majales.Majles.DTO
{
    public class UpdateMajlesInput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public int ClassificationId { get; set; }
        public bool ActiveStatus { get; set; }
    }
}