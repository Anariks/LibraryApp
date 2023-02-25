using Api.Validation;
using Business;
using Contracts.ApiDTO.Requests;
using Contracts.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Business.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
builder.Services.AddScoped<IValidator<CreateBookRequest>, CreateOrUpdateBookValidator>();
builder.Services.AddScoped<IValidator<GetBookByIdRequest>, GetBookByIdRequestValidator>();
builder.Services.AddScoped<IValidator<GetBooksAndOrderRequest>, GetBooksAndOrderRequestValidator>();

//builder.Services.AddSwaggerGen();
builder.Services.Configure<LibConfiguration>(builder.Configuration.GetSection("LibConfiguration"));

builder.Services.AddSingleton<ILibConfiguration, LibConfiguration>();

builder.Services.AddBusinessDataServices();
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

// app.UseHttpsRedirection();
// app.UseAuthorization();

app.MapControllers();

app.Run();
