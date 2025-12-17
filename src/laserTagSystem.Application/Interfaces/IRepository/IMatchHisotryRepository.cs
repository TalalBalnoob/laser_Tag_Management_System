using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IMatchHistoryRepository {
    Task<MatchHistory> AddAsync(MatchHistory matchHistory);
    Task<List<MatchHistory>> GetAllAsync();
}