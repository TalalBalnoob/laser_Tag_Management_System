using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class PlayerScoreRepository (AppDBContext _db): IPlayerScoreRepository {
    
    public async Task<PlayerScore> AddAsync(PlayerScore playerScore) {
        _db.PlayerScores.Add(playerScore);
        await _db.SaveChangesAsync();
        return playerScore;
    }

    public async Task<List<PlayerScore>> GetAllAsync() {
        return await _db.PlayerScores.ToListAsync();
    }
    
    public async Task<PlayerScore> UpdateAsync(PlayerScore playerScore) {
        var PlayerScore = _db.PlayerScores.Update(playerScore).Entity;
        await _db.SaveChangesAsync();
        return PlayerScore;

    }

    public void DeleteAsync(PlayerScore playerScore) {
        _db.PlayerScores.Remove(playerScore);
        _db.SaveChangesAsync();
    }

    public async Task<PlayerScore?> GetByIdAsync(Guid id) {
        return await _db.PlayerScores.FindAsync(id);
    }
}