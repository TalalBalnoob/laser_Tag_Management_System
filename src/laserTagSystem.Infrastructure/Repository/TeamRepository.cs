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
}