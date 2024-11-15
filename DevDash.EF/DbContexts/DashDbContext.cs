using DevDash.Domain.Models.Dash;
using DevDash.Domain.Models.Dev;
using Microsoft.EntityFrameworkCore;

namespace DevDash.EF.DbContexts
{
    public class DashDbContext : DbContext
    {
        public DashDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<SubSystem> SubSystems { get; set; }
        public DbSet<DevTask> DevTasks { get; set; }
    }
}
