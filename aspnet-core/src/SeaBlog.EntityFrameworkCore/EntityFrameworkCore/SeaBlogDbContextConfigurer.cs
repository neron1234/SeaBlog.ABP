using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SeaBlog.EntityFrameworkCore
{
    public static class SeaBlogDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SeaBlogDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SeaBlogDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseNpgsql(connection);
        }
    }
}
