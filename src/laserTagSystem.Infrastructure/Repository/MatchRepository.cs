using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class MatchRepository (AppDBContext _db): IMatchRepository {
    
    public async Task<Match> AddAsync(Match match) {
        _db.Matches.Add(match);
        await _db.SaveChangesAsync();
        return match;
    }
    
    public async Task<List<Match>> GetAllAsync() {
        return await _db.Matches.ToListAsync();
    }
    
    public async Task<Match> UpdateAsync(Match match) {
        var Match = _db.Matches.Update(match).Entity;
        await _db.SaveChangesAsync();
        return Match;

    }
    
    public void DeleteAsync(Match match) {
        _db.Matches.Remove(match);
        _db.SaveChangesAsync();
    }

  

    public async Task<Match?> GetByIdAsync(Guid id) {
        return await _db.Matches.FindAsync(id);
    }
}