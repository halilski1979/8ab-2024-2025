using Microsoft.EntityFrameworkCore;

namespace WebFabric_For_Cars.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) 
        { }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Model>()
                .HasIndex(m => m.ModelId)
                .IsUnique();
            base.OnModelCreating(modelBuilder);
        }

    }
}
