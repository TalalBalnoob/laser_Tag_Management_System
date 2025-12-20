using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface ITeamRepository {
    Task<Team> AddAsync(Team team);
    Task<List<Team>> GetAllAsync();
    Task<Team> UpdateAsync(Team team);
    void DeleteAsync(Team team);
    Task<Team?> GetByIdAsync(Guid id);
}