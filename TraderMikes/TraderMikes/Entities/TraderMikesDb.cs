using Microsoft.EntityFrameworkCore;

namespace TraderMikes.Entities
{
    public class TraderMikesDb : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Item> Items { get; set; }

        public TraderMikesDb(DbContextOptions<TraderMikesDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new ItemConfiguration());
        }
    }
}