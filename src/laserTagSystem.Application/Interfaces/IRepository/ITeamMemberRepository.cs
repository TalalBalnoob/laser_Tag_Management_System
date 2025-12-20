using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface ITeamMemberRepository {
    Task<TeamMember> AddAsync(TeamMember teamMember);
    Task<List<TeamMember>> GetAllAsync();
    Task<TeamMember> UpdateAsync(TeamMember teamMember);
    void DeleteAsync(TeamMember teamMember);
    Task<TeamMember?> GetByIdAsync(Guid id);
}