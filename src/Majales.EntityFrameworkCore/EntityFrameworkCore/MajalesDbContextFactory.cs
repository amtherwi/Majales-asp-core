using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Majales.Configuration;
using Majales.Web;

namespace Majales.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MajalesDbContextFactory : IDesignTimeDbContextFactory<MajalesDbContext>
    {
        public MajalesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MajalesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MajalesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MajalesConsts.ConnectionStringName));

            return new MajalesDbContext(builder.Options);
        }
    }
}
