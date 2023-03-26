using FluentValidation;
using FluentValidationDemo.Models;

namespace FluentValidationDemo.Validators;

public class StudioValidator : AbstractValidator<Studio>
{
    public StudioValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Address).SetValidator(new AddressValidator());
    }
}

internal class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(a => a.Street).Custom((street, context) =>
        {
            if (string.IsNullOrEmpty(street))
            {
                context.AddFailure("Street is required");
            }
        });
    }
}