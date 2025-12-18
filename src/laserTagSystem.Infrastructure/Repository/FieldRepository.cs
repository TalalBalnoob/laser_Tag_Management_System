using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Domain.Entity;
using laserTagSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace laserTagSystem.Infrastructure.Repository;

public class FieldRepository (AppDBContext _db): IFieldRepository {
    
    public async Task<Field> AddAsync(Field field) {
        _db.Fields.Add(field);
        await _db.SaveChangesAsync();
        return field;
    }

    public async Task<Field> UpdateAsync(Field field) {
        var updatedField = _db.Fields.Update(field).Entity;
        await _db.SaveChangesAsync();
        return updatedField;

    }

    public async void DeleteAsync(Field field) {
        _db.Fields.Remove(field);
        await _db.SaveChangesAsync();
    }

    public async Task<List<Field>> GetAllAsync() {
        return await _db.Fields.ToListAsync();
    }

    public async Task<Field?> GetByIdAsync(Guid id) {
        return await _db.Fields.FindAsync(id);
    }

    public async Task<List<Field>> GetAvailableAsync() {
        return await _db.Fields.Where(f => f.IsAvailable == true).ToListAsync();
    }

    public async Task<List<Field>> GetUnBookedFieldsByDateAsync(DateOnly date) {
        var start = date.ToDateTime(TimeOnly.MinValue);
        var end   = date.ToDateTime(TimeOnly.MaxValue);

        return await _db.Fields
            .Include(f => f.Matches)
            .Where(field =>
                !field.Matches.Any(match =>
                    match.StartingTime < end &&
                    match.EndingTime > start
                )
            )
            .ToListAsync();
    }
}