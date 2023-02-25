using Contracts.ApiDTO.Requests;
using FluentValidation;

namespace Api.Validation;

public class DelBookByIdRequestValidator : AbstractValidator<DelBookByIdRequest>
{
    public DelBookByIdRequestValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0).WithMessage("The ID must be greater than 0");
        RuleFor(x => x.Secret)
            .NotNull()
            .NotEmpty()
            .WithMessage("To delete book, you have to add SecretKey");
    }
}
