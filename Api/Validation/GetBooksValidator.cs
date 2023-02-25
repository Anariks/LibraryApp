using Contracts.ApiDTO;
using FluentValidation;

namespace Api.Validation;

public class GetRecommendedBooksRequestValidator : AbstractValidator<GetRecommendedBooksRequest>
{
    public GetRecommendedBooksRequestValidator()
    {
        RuleFor(prop => prop.Genre).NotNull().NotEmpty();
    }
}

public class GetBooksAndOrderRequestValidator : AbstractValidator<GetBooksAndOrderRequest>
{
    public GetBooksAndOrderRequestValidator()
    {
        List<string> orderByOptions = new List<string>() { "title", "author" };
        RuleFor(prop => prop.Order)
            .Must(x => orderByOptions.Contains(x.ToLower()))
            .WithMessage($"You have to sort by " + String.Join(" or ", orderByOptions));
    }
}

public class GetBookByIdRequestValidator : AbstractValidator<GetBookByIdRequest>
{
    public GetBookByIdRequestValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0).WithMessage("The ID must be greater than 0");
    }
}
