namespace Majales.Majles.DTO
{
    public class GetMajlesOutput
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public Models.Classification Classification { get; set; }
        public bool ActiveStatus { get; set; }

    }
}