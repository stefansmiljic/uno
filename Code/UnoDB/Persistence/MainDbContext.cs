using Microsoft.EntityFrameworkCore;
using Uno.Entities;
namespace Uno.Persistence;

public class MainDbContext : DbContext, IMainDbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().ToTable("Players");
        modelBuilder.Entity<Game>().ToTable("Games");
    }
}