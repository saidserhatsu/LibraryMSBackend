using FluentValidation;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(m => m.PhoneNumber).NotEmpty()
            .Matches(@"^\d{11}$") // Telefon numaras� 10 basamakl� olmal� ve yaln�zca rakamlar i�ermelidir.
            .WithMessage("Telefon numaras� ge�erli bir formatta olmal�d�r. (�rn: 05551234567)");
        RuleFor(m => m.DateOfBirth).NotEmpty()
            .LessThan(DateTime.Today.AddYears(-7)) // En az 7 y�l �nce do�mu� olmal�.
            .WithMessage("Do�um tarihi en az 7 y�l �nce olmal�d�r.");
        RuleFor(c => c.Subscribe).NotEmpty();
    }
}