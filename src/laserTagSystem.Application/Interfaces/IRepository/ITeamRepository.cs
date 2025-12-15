using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface ITeamRepository {
    Task<Team> AddAsync(Team team);
    Task<List<Team>> GetAllAsync();
}