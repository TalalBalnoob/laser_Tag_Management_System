using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class MatchParticipantRepository (AppDBContext _db): IMatchParticipantRepository {
    
    public async Task<MatchParticipant> AddAsync(MatchParticipant matchParticipant) {
        _db.MatchParticipants.Add(matchParticipant);
        await _db.SaveChangesAsync();
        return matchParticipant;
    }

    public async Task<List<MatchParticipant>> GetAllAsync() {
        return await _db.MatchParticipants.ToListAsync();
    }
}