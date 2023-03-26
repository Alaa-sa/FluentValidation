using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators
{
    public class GameTypeValidator : AbstractValidator<GameType>
    {
        public GameTypeValidator()
        {
            RuleFor(x => x.MinAge).InclusiveBetween(0, 18);
            RuleForEach(t => t.Tags).IsInEnum().WithMessage("Invalid tag");
            RuleFor(x => x.Platform).IsInEnum();
        }
    }
}