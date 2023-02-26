using Contracts.ApiDTO;
using Contracts.Exceptions;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

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

        services
            .AddMvc()
            .ConfigureApiBehaviorOptions(options =>
            {
                options.InvalidModelStateResponseFactory = c =>
                {
                    var errors = string.Join(
                        '\n',
                        c.ModelState.Values
                            .Where(v => v.Errors.Count > 0)
                            .SelectMany(v => v.Errors)
                            .Select(v => v.ErrorMessage)
                    );

                    return new BadRequestObjectResult(
                        new { ErrorCode.BadRequest, Message = errors }
                    );
                };
            });

        return services;
    }
}
