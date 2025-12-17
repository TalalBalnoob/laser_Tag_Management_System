namespace laserTagSystem.Domain.Entity;

public class Team {
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DateTime CreatedAt { get; set; } = new DateTime();
    
    public List<Player> Players { get; set; } = new();
}