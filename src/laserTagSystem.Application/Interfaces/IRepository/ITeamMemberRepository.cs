using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface ITeamMemberRepository {
    Task<TeamMember> AddAsync(TeamMember teamMember);
    Task<List<TeamMember>> GetAllAsync();
}