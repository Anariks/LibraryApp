using Contracts.ApiDTO.Requests;
using FluentValidation;

namespace Api.Validation;

public class CreateOrUpdateBookValidar : AbstractValidator<CreateBookRequestDto>
{
    public CreateOrUpdateBookValidar()
    {
        RuleFor(book => book.Id).GreaterThanOrEqualTo(0);
        RuleFor(book => book.Title).NotNull();
        RuleFor(book => book.Genre).NotNull();
        RuleFor(book => book.Author).NotNull();
        RuleFor(book => book.Content).NotNull();
        RuleFor(book => book.Genre).NotNull();
    }
}
