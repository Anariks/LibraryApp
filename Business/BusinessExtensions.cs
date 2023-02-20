using Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Business;

public static class BusinessDataExtensions
{
    public static IServiceCollection AddBusinessDataServices(this IServiceCollection services)
    {
        return services.AddDbContext<LibDbContext>();
    }
}
