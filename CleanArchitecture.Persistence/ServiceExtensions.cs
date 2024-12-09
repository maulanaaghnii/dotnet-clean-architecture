using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql;

namespace CleanArchitecture.Persistence;

public static class ServiceExtensions
{
    public static void ConfigurePersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("MySql");
        //services.AddDbContext<DataContext>(opt => opt.UseSqlite(connectionString));
        //services.AddDbContext<DataContext>(opt => opt.UseMySql(ServerVersion.AutoDetect(connectionString)));
        services.AddDbContext<DataContext>(options =>
            options.UseMySql(configuration.GetConnectionString("MySql"),
            ServerVersion.AutoDetect(configuration.GetConnectionString("MySql"))));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
    }
}