using Contracts.ApiDTO;
using FluentValidation;

namespace Api.Validation;

public class CreateReviewRequestValidator : AbstractValidator<CreateReviewRequest>
{
    public int Id { get; init; }
    public string Message { get; init; }
    public string Reviewer { get; init; }

    public CreateReviewRequestValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0).WithMessage("The ID must be greater than 0");
        RuleFor(x => x.Message).NotNull().NotEmpty().WithMessage("Put some words into review!");
        RuleFor(x => x.Reviewer).NotNull().NotEmpty().WithMessage("Put Reviewer Name");
    }
}
