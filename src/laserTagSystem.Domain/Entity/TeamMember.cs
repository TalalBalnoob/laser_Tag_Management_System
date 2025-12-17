namespace laserTagSystem.Domain.Entity;

public class TeamMember {
    public Guid TeamId { get; set; }
    public Guid PlayerId { get; set; }

    public Team Team { get; set; } = null;
    public Player Player { get; set; } = null;
}