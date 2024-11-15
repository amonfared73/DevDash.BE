using DevDash.Domain.Models.Dash;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDash.EF.Configurations.Dash
{
    public class DevTaskConfiguration : IEntityTypeConfiguration<DevTask>
    {
        public void Configure(EntityTypeBuilder<DevTask> builder)
        {
            builder.ToTable("DevTasks", "Dash");
        }
    }
}
