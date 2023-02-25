using Data.Database;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Business.Mapper;
using Contracts.Interfaces;
using Data.Repository;

namespace Business;

public static class BusinessDataExtensions
{
    public static IServiceCollection AddBusinessDataServices(this IServiceCollection services)
    {
        services
            .AddDbContext<LibDbContext>()
            .AddSingleton(_ =>
            {
                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<LibProfile>();
                });

                return configuration.CreateMapper();
            })
            .AddTransient<ILibRepository, LibRepository>();
        // .AddSingleton<ILibService, LibService>();
        return services;
    }
}
