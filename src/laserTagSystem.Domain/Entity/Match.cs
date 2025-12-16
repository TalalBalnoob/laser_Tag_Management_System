using laserTagSystem.Domain.Enums;
using MatchType = System.IO.MatchType;

namespace laserTagSystem.Domain.Entity;

public class Match {
    public Guid Id { get; set; }
    
    public DateTime StartingTime { get; set; }
    public DateTime EndingTime { get; set; }
    
    public Guid FieldId { get; set; }
    
    public MatchType Type { get; set; }   // TeamBased, FreeForAll
    public MatchStatus Status { get; set; } // Scheduled, Ongoing, Finished
}