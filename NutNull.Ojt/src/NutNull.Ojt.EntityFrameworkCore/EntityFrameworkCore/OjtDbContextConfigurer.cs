using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NutNull.Ojt.EntityFrameworkCore
{
    public static class OjtDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OjtDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OjtDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
