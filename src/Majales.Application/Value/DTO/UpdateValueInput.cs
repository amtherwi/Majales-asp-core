using System;
namespace Majales.Value.DTO
{
    public class UpdateValueInput
    {
        public int Id { get; set; }
        public int CEO_inCost { get; set; }
        public int CEO_outCost { get; set; }

        public int Sec_inCost { get; set; }
        public int Sec_outCost { get; set; }
        public int MSec_inCost { get; set; }
        public int MSec_outCost { get; set; }
        public int Mem_inCost { get; set; }
        public int Mem_outCost { get; set; }
    }
}
