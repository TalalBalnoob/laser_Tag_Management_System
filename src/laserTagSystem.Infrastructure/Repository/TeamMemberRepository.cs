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
    
    public async Task<TeamMember> UpdateAsync(TeamMember teamMember) {
        var TeamMember = _db.TeamMembers.Update(teamMember).Entity;
        await _db.SaveChangesAsync();
        return TeamMember;

    }

    public void DeleteAsync(TeamMember teamMember) {
        _db.TeamMembers.Remove(teamMember);
        _db.SaveChangesAsync();
    }

    public async Task<TeamMember?> GetByIdAsync(Guid id) {
        return await _db.TeamMembers.FindAsync(id);
    }
}