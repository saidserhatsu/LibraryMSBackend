using FluentValidation;

namespace Application.Features.LibraryStaffs.Commands.Update;

public class UpdateLibraryStaffCommandValidator : AbstractValidator<UpdateLibraryStaffCommand>
{
    public UpdateLibraryStaffCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FirstName).NotEmpty();
        RuleFor(c => c.LastName).NotEmpty();
        RuleFor(c => c.BirthDate).NotEmpty();
        RuleFor(c => c.Image).NotEmpty();
    }
}