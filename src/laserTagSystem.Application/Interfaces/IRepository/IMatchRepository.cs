using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IMatchRepository {
    Task<Match> AddAsync(Match match);
    Task<List<Match>> GetAllAsync();
    Task<Match> UpdateAsync(Match match);
    void DeleteAsync(Match match);
    Task<Match?> GetByIdAsync(Guid id);
}