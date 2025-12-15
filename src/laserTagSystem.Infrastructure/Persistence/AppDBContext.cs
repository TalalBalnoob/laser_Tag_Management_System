using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.Infrastructure.Persistence;

public class AppDBContext: DbContext  {
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {
        
    }
}