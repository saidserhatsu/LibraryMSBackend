using FluentValidation;

namespace Application.Features.LibraryStaffs.Commands.Delete;

public class DeleteLibraryStaffCommandValidator : AbstractValidator<DeleteLibraryStaffCommand>
{
    public DeleteLibraryStaffCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}