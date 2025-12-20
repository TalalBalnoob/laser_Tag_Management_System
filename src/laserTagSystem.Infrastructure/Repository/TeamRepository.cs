using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class TeamRepository (AppDBContext _db): ITeamRepository {
    
    public async Task<Team> AddAsync(Team team) {
        _db.Teams.Add(team);
        await _db.SaveChangesAsync();
        return team;
    }

    public async Task<List<Team>> GetAllAsync() {
        return await _db.Teams.ToListAsync();
    }
    
    public async Task<Team> UpdateAsync(Team team) {
        var Team = _db.Teams.Update(team).Entity;
        await _db.SaveChangesAsync();
        return Team;

    }

    public void DeleteAsync(Team team) {
        _db.Teams.Remove(team);
        _db.SaveChangesAsync();
    }

    public async Task<Team?> GetByIdAsync(Guid id) {
        return await _db.Teams.FindAsync(id);
    }
}