using FluentValidation;
namespace TesteSuper.Models;

public class Validador : AbstractValidator<Recebe>
{
    public Validador()
    {
        RuleFor(x => x.InputString)
            .NotEmpty().WithMessage("A propriedade InputString não pode estar vazia.");
    }
}
