using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebAvtosalon.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Engine> Engines { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cars__3214EC079139136A");

            entity.HasOne(d => d.Category).WithMany(p => p.Cars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_car_category");

            entity.HasOne(d => d.Engine).WithMany(p => p.Cars)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_car_engine");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07E9001428");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3214EC07E35B14A3");
        });

        modelBuilder.Entity<Engine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Engines__3214EC07B8BED097");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sales__3214EC07A32C3427");

            entity.HasOne(d => d.Car).WithMany(p => p.Sales).HasConstraintName("fk_sale_car");

            entity.HasOne(d => d.Client).WithMany(p => p.Sales).HasConstraintName("fk_sale_client");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
