namespace laserTagSystem.Domain.Entity;

public class Match {
    public Guid Id { get; set; }
    
    public DateTime StartingTime { get; set; }
    public DateTime EndingTime { get; set; }
    
    public Guid FieldId { get; set; }
}