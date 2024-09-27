using GameLibraryDb.models;
using Microsoft.EntityFrameworkCore;

namespace GameLibraryDb;

public class GameLibraryDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Game> Games { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Screenshot> Screenshots { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Define explicit one-to-many relation
        modelBuilder.Entity<Game>()
            .HasMany(e => e.Screenshots)
            .WithOne(e => e.Game)
            .HasForeignKey(e => e.GameId)
            .IsRequired();
        
        // Define explicit one-to-one relation
        modelBuilder.Entity<Game>()
            .HasOne(e => e.Review)
            .WithOne(e => e.Game)
            .HasForeignKey<Review>(e => e.GameId)
            .IsRequired();
    }
}