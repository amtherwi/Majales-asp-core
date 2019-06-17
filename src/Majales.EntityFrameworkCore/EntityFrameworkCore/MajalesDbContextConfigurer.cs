using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Majales.EntityFrameworkCore
{
    public static class MajalesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MajalesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MajalesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
