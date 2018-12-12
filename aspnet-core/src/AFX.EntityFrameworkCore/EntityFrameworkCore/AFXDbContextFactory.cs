using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AFX.Configuration;
using AFX.Web;

namespace AFX.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AFXDbContextFactory : IDesignTimeDbContextFactory<AFXDbContext>
    {
        public AFXDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AFXDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AFXDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AFXConsts.ConnectionStringName));

            return new AFXDbContext(builder.Options);
        }
    }
}
