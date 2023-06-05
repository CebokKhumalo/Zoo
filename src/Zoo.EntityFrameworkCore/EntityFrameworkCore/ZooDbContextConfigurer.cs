using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Zoo.EntityFrameworkCore
{
    public static class ZooDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZooDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZooDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
