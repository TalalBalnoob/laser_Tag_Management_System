namespace laserTagSystem.Domain.Entity;

public class Player {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string NickName { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TeamMember> Teams { get; set; } = new List<TeamMember>();
}