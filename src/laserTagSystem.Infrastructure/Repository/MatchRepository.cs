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
}