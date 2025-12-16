namespace laserTagSystem.Domain.Entity;

public class Field {
    public Guid Id { get; set; }
    public int MaxPlayers { get; set; }
    public bool IsAvailable { get; set; } = true;
}