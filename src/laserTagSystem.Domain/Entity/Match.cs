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
        if (this.Status != MatchStatus.Scheduled) {
            throw new DomainException("Can't mark UnScheduled game as Ongoing");
        }

        this.Status = MatchStatus.Ongoing;
    }
    
    public void MarkScheduled() {
        if (this.Status != MatchStatus.Ongoing) {
            throw new DomainException("Can't mark this game as Scheduled");
        }

        this.Status = MatchStatus.Scheduled;
    }
    
    public void MarkCancelled() {
        if (this.Status != MatchStatus.Finished) {
            throw new DomainException("Can't mark Finished game as Cancelled");
        }

        this.Status = MatchStatus.Cancelled;
    }
}