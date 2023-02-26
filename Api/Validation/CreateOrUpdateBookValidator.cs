using Contracts.ApiDTO;
using FluentValidation;

namespace Api.Validation;

public class CreateOrUpdateBookValidator : AbstractValidator<CreateBookRequest>
{
    public CreateOrUpdateBookValidator()
    {
        RuleFor(book => book.Id).GreaterThanOrEqualTo(0);
        RuleFor(book => book.Title).NotNull().NotEmpty();
        RuleFor(book => book.Genre).NotNull();
        RuleFor(book => book.Author).NotNull();
        RuleFor(book => book.Content).NotNull();
        RuleFor(book => book.Genre).NotNull();
    }
}
