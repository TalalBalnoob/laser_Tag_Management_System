using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class TeamMemberRepository (AppDBContext _db): ITeamMemberRepository {
    
    public async Task<TeamMember> AddAsync(TeamMember teamMember) {
        _db.TeamMembers.Add(teamMember);
        await _db.SaveChangesAsync();
        return teamMember;
    }

    public async Task<List<TeamMember>> GetAllAsync() {
        return await _db.TeamMembers.ToListAsync();
    }
}