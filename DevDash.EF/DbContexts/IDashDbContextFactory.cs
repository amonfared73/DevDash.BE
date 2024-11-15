namespace DevDash.EF.DbContexts
{
    public interface IDashDbContextFactory
    {
        DashDbContext CreateDbContext();
    }
}
