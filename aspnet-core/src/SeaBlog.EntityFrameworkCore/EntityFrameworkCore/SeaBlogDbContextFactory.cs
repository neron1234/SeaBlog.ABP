using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SeaBlog.Configuration;
using SeaBlog.Web;

namespace SeaBlog.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SeaBlogDbContextFactory : IDesignTimeDbContextFactory<SeaBlogDbContext>
    {
        public SeaBlogDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SeaBlogDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SeaBlogDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SeaBlogConsts.ConnectionStringName));

            return new SeaBlogDbContext(builder.Options);
        }
    }
}
