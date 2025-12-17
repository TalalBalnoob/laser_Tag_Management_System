namespace laserTagSystem.Domain.Entity;

public class Field {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}