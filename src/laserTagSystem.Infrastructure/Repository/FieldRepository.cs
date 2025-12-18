using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Repository;

public class FieldRepository (AppDBContext _db): IFieldRepository {
    
    public async Task<Field> AddAsync(Field field) {
        _db.Fields.Add(field);
        await _db.SaveChangesAsync();
        return field;
    }

    public async Task<List<Field>> GetAllAsync() {
        return await _db.Fields.ToListAsync();
    }
}