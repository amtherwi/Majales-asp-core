using System;
namespace Majales.MajlisMembership.DTO
{
    public class CreateMajlisMembershipInput
    {
        public int MajlesId { get; set; }
        public int MemberId { get; set; }
        public int RoleId { get; set; }
        public DateTime Date { get; set; }

    }
}
