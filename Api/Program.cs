using Api.Validation;
using Business;
using Contracts.Interfaces;
using FluentValidation.AspNetCore;
using Business.Configuration;
using Serilog;
using HybridModelBinding;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog(
    (ctx, lc) =>
    {
        lc.ReadFrom.Configuration(builder.Configuration);
    }
);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services
    .AddMvc()
    .AddHybridModelBinder(options =>
    {
        options.FallbackBindingOrder = new[] { Source.Route, Source.Body, Source.QueryString };
    });

builder.Services.AddFluentValidation();

builder.Services.Configure<LibConfiguration>(builder.Configuration.GetSection("LibConfiguration"));

builder.Services.AddSingleton<ILibConfiguration, LibConfiguration>();

builder.Services.AddBusinessDataServices();

builder.Services.AddScoped<ILibService, LibService>();

var app = builder.Build();

app.UseMiddleware<LoggingRequestMiddleware>();
app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
