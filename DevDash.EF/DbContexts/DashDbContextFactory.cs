using Microsoft.EntityFrameworkCore;

namespace DevDash.EF.DbContexts
{
    public class DashDbContextFactory : IDashDbContextFactory
    {
        private readonly DbContextOptions _options;

        public DashDbContextFactory(DbContextOptions options)
        {
            _options = options;
        }

        public DashDbContext CreateDbContext()
        {
            return new DashDbContext(_options);
        }
    }
}
