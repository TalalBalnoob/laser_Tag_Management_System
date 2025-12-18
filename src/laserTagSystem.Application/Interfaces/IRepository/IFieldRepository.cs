using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IFieldRepository {
    Task<Field> AddAsync(Field field);
    Task<Field> UpdateAsync(Field field);
    void DeleteAsync(Field field);
    Task<List<Field>> GetAllAsync();
    Task<Field?> GetByIdAsync(Guid id);
    Task<List<Field>> GetAvailableAsync();
    Task<List<Field>> GetUnBookedFieldsByDateAsync(DateOnly date);
}