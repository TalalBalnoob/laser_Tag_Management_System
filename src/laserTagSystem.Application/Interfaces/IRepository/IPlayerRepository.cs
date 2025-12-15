using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IPlayerRepository {
    Task<Player> AddAsync(Player player);
    Task<List<Player>> GetAllAsync();
}