using FluentValidation;
using PollAPI.DTOs;

namespace PollAPI.Validators;

public class PollInputValidator : AbstractValidator<PollInputDto>
{
    public PollInputValidator()
    {
        RuleFor(poll => poll.Name)
            .NotEmpty().WithMessage("Poll name is required");
        
        /*RuleFor(poll => poll.Name)
            .NotEmpty()
            .Matches(@"^[A-Z0-9 _]*$")
            .WithMessage("Invalid name format.");*/

/*        RuleFor(poll => poll.Options.Count)
            .GreaterThanOrEqualTo(2)
            .WithMessage("At least 2 options is required");
            
            
*/
        RuleForEach(poll => poll.Options).ChildRules(option =>
        {
            option.RuleFor(o => o.Name)
                .NotEmpty().WithMessage("Option name can not be empty");
        });

    }
}