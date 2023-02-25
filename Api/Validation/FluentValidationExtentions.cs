using Contracts.ApiDTO;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Api.Validation;

public static class FluentValidationExtensions
{
    public static IServiceCollection AddFluentValidation(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

        services.AddTransient<IValidator<GetBookByIdRequest>, GetBookByIdRequestValidator>();
        services.AddTransient<
            IValidator<GetBooksAndOrderRequest>,
            GetBooksAndOrderRequestValidator
        >();
        services.AddTransient<IValidator<GetBookByIdRequest>, GetBookByIdRequestValidator>();
        services.AddTransient<IValidator<DelBookByIdRequest>, DelBookByIdRequestValidator>();
        services.AddTransient<IValidator<CreateBookRequest>, CreateOrUpdateBookValidator>();
        services.AddTransient<IValidator<CreateReviewRequest>, CreateReviewRequestValidator>();
        services.AddTransient<IValidator<CreateRateRequest>, CreateRateRequestValidator>();

        return services;
    }
}
