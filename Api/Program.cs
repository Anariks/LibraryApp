using Api.Validation;
using Business;
using Contracts.ApiDTO;
using Contracts.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Business.Configuration;
using Serilog;
using HybridModelBinding;

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

// Add Serilog logging
// Log.Logger = new LoggerConfiguration().Enrich.FromLogContext().WriteTo.Console().CreateLogger();

builder.Host.UseSerilog(
    (ctx, lc) =>
    {
        lc.ReadFrom.Configuration(builder.Configuration);
    }
);

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddFluentValidation();

//builder.Services.AddSwaggerGen();
builder.Services.Configure<LibConfiguration>(builder.Configuration.GetSection("LibConfiguration"));

builder.Services.AddSingleton<ILibConfiguration, LibConfiguration>();

builder.Services.AddBusinessDataServices();
builder.Services
    .AddMvc()
    .AddHybridModelBinder(options =>
    {
        /**
         * This is optional and overrides internal ordering of how binding gets applied to a model that doesn't have explicit binding-rules.
         * Internal ordering is: body => form-values => route-values => querystring-values => header-values
         */
        options.FallbackBindingOrder = new[] { Source.Route, Source.Body, Source.QueryString };
    });
builder.Services.AddScoped<ILibService, LibService>();

// builder.Configuration.Bind("LibConfiguration", new LibConfiguration());

//builder.Services.AddDbContext();

//  ,//.EnableSensitiveDataLogging(),
// contextLifetime: ServiceLifetime.Transient,
// optionsLifetime: ServiceLifetime.Singleton);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwagger();
    // app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

// app.UseHttpsRedirection();
// app.UseAuthorization();

app.MapControllers();

app.Run();
