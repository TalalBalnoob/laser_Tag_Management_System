namespace laserTagSystem.Domain.Entity;

public class ParticipantScore {
    public Guid Id { get; set; }
    
    public Guid MatchParticipantId { get; set; }
    
    public double Score { get; set; }

    public MatchParticipant MatchParticipant { get; set; } = null!;
}