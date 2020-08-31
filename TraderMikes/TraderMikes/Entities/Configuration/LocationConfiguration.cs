using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TraderMikes.Entities
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");

            builder.HasKey(e => e.LocationId);

            builder.Property(e => e.LocationId)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.CreatedDate)
                .HasColumnType("datetime2(2)")
                .IsRequired();

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}