using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using laserTagSystem.Domain.Enums;
using MatchType = laserTagSystem.Domain.Enums.MatchType;

namespace laserTagSystem.Domain.Entity;

public class Match {
    [Key]
    public Guid Id { get; set; }
    
    public DateTime StartingTime { get; set; }
    public DateTime EndingTime { get; set; }
    
    public Guid FieldId { get; set; }
    
    public MatchType Type { get; set; }   // TeamBased, FreeForAll
    public MatchStatus Status { get; set; } // Scheduled, Ongoing, Finished

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public Field Field { get; set; } = null!;
}