using System.ComponentModel.DataAnnotations;
using laserTagSystem.Domain.Exceptions;

namespace laserTagSystem.Domain.Entity;

public class Field {
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    
    [Range(0,999)]
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Match> Matches { get; set; } = new List<Match>();
    
    public void MarkUnavailable() {
        if (!IsAvailable)
            throw new DomainException("Field is already unavailable");
    
        IsAvailable = false;
    }
}