namespace laserTagSystem.Domain.Entity;

public class MatchHistory {
    public Guid Id { get; set; }

    public string SnapShotData { get; set; } = "{}";
    
    public Guid MatchId { get; set; }
    public Match Match { get; set; } = null!;
}