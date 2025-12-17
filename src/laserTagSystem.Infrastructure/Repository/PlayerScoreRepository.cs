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
}