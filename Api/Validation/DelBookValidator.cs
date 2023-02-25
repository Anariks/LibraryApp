using Contracts.ApiDTO;
using FluentValidation;

namespace Api.Validation;

public class DelBookByIdRequestValidator : AbstractValidator<DelBookByIdRequest>
{
    public DelBookByIdRequestValidator()
    {
        RuleFor(x => x.Id).NotEmpty().GreaterThan(0).WithMessage("The ID must be greater than 0");
        RuleFor(x => x.Secret)
            .NotNull()
            .NotEmpty()
            .WithMessage("To delete book, you have to add SecretKey");
    }
}
