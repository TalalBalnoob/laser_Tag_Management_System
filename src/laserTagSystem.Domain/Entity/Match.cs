using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using laserTagSystem.Domain.Enums;
using laserTagSystem.Domain.Exceptions;
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

    public void MarkOngoing() {
        if (Status != MatchStatus.Scheduled) {
            throw new DomainException("Can't mark UnScheduled game as Ongoing");
        }

        Status = MatchStatus.Ongoing;
    }
    
    public void MarkScheduled() {
        if (Status == MatchStatus.Ongoing) {
            throw new DomainException("Can't mark this game as Scheduled");
        }

        Status = MatchStatus.Scheduled;
    }
    
    public void MarkFinshied() {
        if (Status == MatchStatus.Ongoing) {
            throw new DomainException("Can't finish a match that didn't start");
        }

        Status = MatchStatus.Finished;
    }
    
    public void MarkCancelled() {
        if (Status != MatchStatus.Finished) {
            throw new DomainException("Can't mark Finished game as Cancelled");
        }

        Status = MatchStatus.Cancelled;
    }
}