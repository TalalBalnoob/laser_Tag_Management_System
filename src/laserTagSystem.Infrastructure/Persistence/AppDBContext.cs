using laserTagSystem.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Persistence;

public class AppDBContext: DbContext  {
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {
        
    }
    
    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<Match> Matches { get; set; }
}