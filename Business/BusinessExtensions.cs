using Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Contracts.Interfaces;
using Data.Repository;

namespace Business;

public static class BusinessDataExtensions
{
    public static IServiceCollection AddBusinessDataServices(this IServiceCollection services)
    {
        services.AddDbContext<LibDbContext>().AddScoped<ILibRepository, LibRepository>();
        return services;
    }
}
