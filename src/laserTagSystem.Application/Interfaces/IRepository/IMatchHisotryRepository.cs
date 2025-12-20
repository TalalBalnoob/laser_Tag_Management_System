using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IMatchHistoryRepository {
    Task<MatchHistory> AddAsync(MatchHistory matchHistory);
    Task<List<MatchHistory>> GetAllAsync();
    Task<MatchHistory> UpdateAsync(MatchHistory matchHistory);
    void DeleteAsync(MatchHistory matchHistory);
    Task<MatchHistory?> GetByIdAsync(Guid id);
}