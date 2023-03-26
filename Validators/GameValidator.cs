using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators;

public class GameValidator : AbstractValidator<Game>
{
    public GameValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Id).GreaterThan(-1);
        RuleFor(x => x.Genre).SetValidator(new GameTypeValidator());
        RuleFor(x => x.Manufacturer).SetValidator(new StudioValidator());
    }
}
