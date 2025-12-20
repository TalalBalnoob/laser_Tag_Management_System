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
    
    public async Task<MatchParticipant> UpdateAsync(MatchParticipant matchParticipant) {
        var MatchParticipant = _db.MatchParticipants.Update(matchParticipant).Entity;
        await _db.SaveChangesAsync();
        return MatchParticipant;

    }

    public void DeleteAsync(MatchParticipant matchParticipant) {
        _db.MatchParticipants.Remove(matchParticipant);
        _db.SaveChangesAsync();
    }

    

    public async Task<MatchParticipant?> GetByIdAsync(Guid id) {
        return await _db.MatchParticipants.FindAsync(id);
    }
}