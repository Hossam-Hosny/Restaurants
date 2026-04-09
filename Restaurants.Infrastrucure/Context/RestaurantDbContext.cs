using Microsoft.EntityFrameworkCore;
using Restaurants.Domain.Entities;

namespace Restaurants.Infrastrucure.Context;

internal class RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : DbContext(options)
{
    internal DbSet<Restaurant> Restaurants { get; set; } 
    internal DbSet<Dishes> Dishes { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Restaurant>()
            .OwnsOne(r=>r.Address);

        modelBuilder.Entity<Restaurant>()
            .HasMany(r => r.Dishes)
            .WithOne()
            .HasForeignKey(d => d.RestaurantId);
    }

}
