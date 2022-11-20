using FluentValidation.Net.Models;

namespace FluentValidation.Net.Validators
{
    public class CoffeeModelValidator : AbstractValidator<CoffeeModel>
    {
        public CoffeeModelValidator() 
        {
            RuleFor(coffee => coffee.Title)
                .NotNull()
                .NotEmpty();

            RuleFor(coffee => coffee.Description)
                .Length(0, 25);

            RuleFor(coffee => coffee.Title)
                .Length(8, 8)
                .WithMessage("The Bar Code must be a mandatory string length of 8.");
        }
    }
}
