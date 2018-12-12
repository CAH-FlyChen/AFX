using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AFX.EntityFrameworkCore
{
    public static class AFXDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AFXDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AFXDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
