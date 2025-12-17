namespace laserTagSystem.Domain.Entity;

public class PlayerScore {
    public Guid Id { get; set; }
    
    public Guid MatchId { get; set; }
    public Guid PlayerId { get; set; }

    public double Score { get; set; } = 0;
    
    public int Kills { get; set; } = 0;
    public int Assists { get; set; } = 0;
}