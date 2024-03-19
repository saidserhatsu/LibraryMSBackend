using FluentValidation;

namespace Application.Features.LibraryStaffs.Commands.Create;

public class CreateLibraryStaffCommandValidator : AbstractValidator<CreateLibraryStaffCommand>
{
    public CreateLibraryStaffCommandValidator()
    {
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.BirthDate).NotEmpty();
        RuleFor(c => c.Image).NotEmpty();
    }
}