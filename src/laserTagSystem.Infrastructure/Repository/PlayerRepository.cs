using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class PlayerRepository (AppDBContext _db): IPlayerRepository {
    
    public async Task<Player> AddAsync(Player player) {
        _db.Players.Add(player);
        await _db.SaveChangesAsync();
        return player;
    }

    public async Task<List<Player>> GetAllAsync() {
        return await _db.Players.ToListAsync();
    }
}