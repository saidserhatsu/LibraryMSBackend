using FluentValidation;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(m => m.PhoneNumber).NotEmpty()
            .Matches(@"^\+[0-9]*$") // Telefon numarasi basinda + isareti bulundurmalidir.
            .WithMessage("Telefon numaras� ge�erli bir formatta olmal�d�r. (�rn: +905551234567)");
        RuleFor(m => m.DateOfBirth).NotEmpty()
            .LessThan(DateTime.Today.AddYears(-7)) // En az 7 y�l �nce do�mu� olmal�.
            .WithMessage("Do�um tarihi en az 7 y�l �nce olmal�d�r.");
        RuleFor(c => c.Subscribe).NotEmpty();
    }
}