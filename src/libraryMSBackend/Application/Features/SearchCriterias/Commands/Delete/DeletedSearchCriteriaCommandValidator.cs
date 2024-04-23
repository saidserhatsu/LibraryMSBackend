using FluentValidation;

namespace Application.Features.SearchCriterias.Commands.Delete;

public class DeleteSearchCriteriaCommandValidator : AbstractValidator<DeleteSearchCriteriaCommand>
{
    public DeleteSearchCriteriaCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}