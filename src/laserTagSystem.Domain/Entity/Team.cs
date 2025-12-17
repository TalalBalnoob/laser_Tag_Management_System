namespace laserTagSystem.Domain.Entity;

public class Team {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public ICollection<TeamMember> Players { get; set; } = new List<TeamMember>();
}