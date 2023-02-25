using Contracts.ApiDTO;
using FluentValidation;

namespace Api.Validation;

public class CreateRateRequestValidator : AbstractValidator<CreateRateRequest>
{
    public CreateRateRequestValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0).WithMessage("The ID must be greater than 0");
        RuleFor(x => x.Score)
            .InclusiveBetween(1, 5)
            .WithMessage("Put your Score from 1 to 5, int only");
    }
}
