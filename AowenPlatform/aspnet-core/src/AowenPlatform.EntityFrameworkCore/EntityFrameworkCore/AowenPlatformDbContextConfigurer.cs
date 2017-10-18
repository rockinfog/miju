using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AowenPlatform.EntityFrameworkCore
{
    public static class AowenPlatformDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AowenPlatformDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AowenPlatformDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}