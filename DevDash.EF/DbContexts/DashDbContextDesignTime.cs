using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DevDash.EF.DbContexts
{
    public class DashDbContextDesignTime : IDesignTimeDbContextFactory<DashDbContext>
    {
        public DashDbContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Database=DevDashDb;Trusted_Connection=True;";
            var optionBuilder = new DbContextOptionsBuilder<DashDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new DashDbContext(optionBuilder.Options);
        }
    }
}
