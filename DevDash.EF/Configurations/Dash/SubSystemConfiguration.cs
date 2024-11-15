using DevDash.Domain.Models.Dash;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevDash.EF.Configurations.Dash
{
    public class SubSystemConfiguration : IEntityTypeConfiguration<SubSystem>
    {
        public void Configure(EntityTypeBuilder<SubSystem> builder)
        {
            builder.ToTable("SubSystems", "Dash");
        }
    }
}
