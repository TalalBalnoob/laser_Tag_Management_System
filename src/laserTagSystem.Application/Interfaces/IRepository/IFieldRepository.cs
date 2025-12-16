using laserTagSystem.Domain.Entity;

namespace laserTagSystem.Application.Interfaces.IRepository;

public interface IFieldRepository {
    Task<Field> AddAsync(Field field);
    Task<List<Field>> GetAllAsync();
}