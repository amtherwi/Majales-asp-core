using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Majales.Authorization.Roles;
using Majales.Authorization.Users;
using Majales.MultiTenancy;
using Majales.Models;

namespace Majales.EntityFrameworkCore
{
    public class MajalesDbContext : AbpZeroDbContext<Tenant, Role, User, MajalesDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Majles> Majles { get; set; }
        public MajalesDbContext(DbContextOptions<MajalesDbContext> options)
            : base(options)
        {
        }
    }
}
