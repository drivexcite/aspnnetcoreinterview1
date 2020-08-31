using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TraderMikes.Entities
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.ToTable("Item");

            builder.HasKey(e => e.ItemId);

            builder.Property(e => e.ItemId)
                .IsRequired();

            builder.Property(e => e.Name)
                .HasMaxLength(60)
                .IsRequired();

            builder.Property(e => e.Price)
                .HasColumnType("money")
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