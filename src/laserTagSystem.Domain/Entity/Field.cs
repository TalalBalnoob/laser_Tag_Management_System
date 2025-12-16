namespace laserTagSystem.Domain.Entity;

public class Field {
    public int Id { get; set; }
    public int Players_capacity { get; set; }
    public bool IsAvailable { get; set; } = true;
}