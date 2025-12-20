using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IMatchParticipantRepository {
    Task<MatchParticipant> AddAsync(MatchParticipant matchParticipant);
    Task<List<MatchParticipant>> GetAllAsync();
    Task<MatchParticipant> UpdateAsync(MatchParticipant matchParticipant);
    void DeleteAsync(MatchParticipant matchParticipant);
    Task<MatchParticipant?> GetByIdAsync(Guid id);
}