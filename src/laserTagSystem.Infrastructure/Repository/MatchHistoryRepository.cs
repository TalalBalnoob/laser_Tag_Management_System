using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class MatchHistoryRepository (AppDBContext _db): IMatchHistoryRepository {
    
    public async Task<MatchHistory> AddAsync(MatchHistory matchHistory) {
        _db.MatchHistories.Add(matchHistory);
        await _db.SaveChangesAsync();
        return matchHistory;
    }

    public async Task<List<MatchHistory>> GetAllAsync() {
        return await _db.MatchHistories.ToListAsync();
    }

    public async Task<MatchHistory> UpdateAsync(MatchHistory matchHistory) {
        var MatchHistory = _db.MatchHistories.Update(matchHistory).Entity;
        await _db.SaveChangesAsync();
        return MatchHistory;

    }

    public void DeleteAsync(MatchHistory matchHistory) {
        _db.MatchHistories.Remove(matchHistory);
        _db.SaveChangesAsync();
    }

    public async Task<MatchHistory?> GetByIdAsync(Guid id) {
        return await _db.MatchHistories.FindAsync(id);
    }
}