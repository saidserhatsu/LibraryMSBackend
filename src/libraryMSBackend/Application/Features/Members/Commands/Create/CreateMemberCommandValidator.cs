using FluentValidation;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(m => m.PhoneNumber).NotEmpty()
            .Matches(@"^\d{11}$") // Telefon numarasý 10 basamaklý olmalý ve yalnýzca rakamlar içermelidir.
            .WithMessage("Telefon numarasý geçerli bir formatta olmalýdýr. (örn: 05551234567)");
        RuleFor(m => m.DateOfBirth).NotEmpty()
            .LessThan(DateTime.Today.AddYears(-7)) // En az 7 yýl önce doðmuþ olmalý.
            .WithMessage("Doðum tarihi en az 7 yýl önce olmalýdýr.");
        RuleFor(c => c.Subscribe).NotEmpty();
    }
}