using Microsoft.EntityFrameworkCore;
using PersonalGameLibrary.Database.models;

namespace PersonalGameLibrary.Database;

public class GameLibraryDbContext(DbContextOptions<GameLibraryDbContext> options) : DbContext(options)
{
    public DbSet<Game> Games { get; init; }
    public DbSet<Review> Reviews { get; init; }
    public DbSet<Screenshot> Screenshots { get; init; }

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