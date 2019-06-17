using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Majales.Authorization.Roles;
using Majales.Authorization.Users;
using Majales.MultiTenancy;

namespace Majales.EntityFrameworkCore
{
    public class MajalesDbContext : AbpZeroDbContext<Tenant, Role, User, MajalesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MajalesDbContext(DbContextOptions<MajalesDbContext> options)
            : base(options)
        {
        }
    }
}
