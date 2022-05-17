using FluentValidation;

namespace BookApp.Core.Domain
{
    public class BookValidationClass : AbstractValidator<Book>
    {
        public BookValidationClass()
        {
            RuleFor(u => u.Name).NotNull().NotEmpty().EmailAddress().WithMessage("name shouldnt be null");

        }
    }
}
