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
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<MatchParticipant> MatchParticipants { get; set; }
    public DbSet<PlayerScore> PlayerScores { get; set; }
    public DbSet<MatchHistory> MatchHistories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TeamMember>()
            .HasKey(tm => new { tm.TeamId, tm.PlayerId });

        modelBuilder.Entity<TeamMember>()
            .HasOne(tm => tm.Team)
            .WithMany(t => t.Players)
            .HasForeignKey(tm => tm.TeamId);

        modelBuilder.Entity<TeamMember>()
            .HasOne(tm => tm.Player)
            .WithMany(p => p.Teams)
            .HasForeignKey(tm => tm.PlayerId);
    }

    
   
}