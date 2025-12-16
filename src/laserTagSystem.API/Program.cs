using laserTagSystem.Application.Interfaces.IRepository;
using laserTagSystem.Infrastructure.Persistence;
using laserTagSystem.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace laserTagSystem.API;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        
        builder.Services.AddDbContext<AppDBContext>(options =>
        {
            options.UseNpgsql(
                builder.Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("laserTagSystem.Infrastructure")
            );
        });
        
        builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
        builder.Services.AddScoped<ITeamRepository, TeamRepository>();
        builder.Services.AddScoped<IFieldRepository, FieldRepository>();
        builder.Services.AddScoped<IMatchRepository, MatchRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment()) {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}