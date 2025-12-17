using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IPlayerScoreRepository {
    Task<PlayerScore> AddAsync(PlayerScore playerScore);
    Task<List<PlayerScore>> GetAllAsync();
}