using System.ComponentModel.DataAnnotations;
using laserTagSystem.Domain.Enums;

namespace laserTagSystem.Domain.Entity;

public class MatchParticipant {
    [Key]
    public Guid Id { get; set; }
    
    public ParticipantType ParticipantType { get; set; }
    public ParticipantSide? ParticipantSide { get; set; }
    
    public Guid MatchId { get; set; }
    public Guid TeamId { get; set; }
    public Guid PlayerId { get; set; }
}