using AowenPlatform.Configuration;
using AowenPlatform.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AowenPlatform.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AowenPlatformDbContextFactory : IDesignTimeDbContextFactory<AowenPlatformDbContext>
    {
        public AowenPlatformDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AowenPlatformDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AowenPlatformDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AowenPlatformConsts.ConnectionStringName));

            return new AowenPlatformDbContext(builder.Options);
        }
    }
}