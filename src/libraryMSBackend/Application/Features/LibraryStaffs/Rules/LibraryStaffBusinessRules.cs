using Application.Features.LibraryStaffs.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.LibraryStaffs.Rules;

public class LibraryStaffBusinessRules : BaseBusinessRules
{
    private readonly ILibraryStaffRepository _libraryStaffRepository;
    private readonly ILocalizationService _localizationService;

    public LibraryStaffBusinessRules(ILibraryStaffRepository libraryStaffRepository, ILocalizationService localizationService)
    {
        _libraryStaffRepository = libraryStaffRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, LibraryStaffsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task LibraryStaffShouldExistWhenSelected(LibraryStaff? libraryStaff)
    {
        if (libraryStaff == null)
            await throwBusinessException(LibraryStaffsBusinessMessages.LibraryStaffNotExists);
    }

    public async Task LibraryStaffIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        LibraryStaff? libraryStaff = await _libraryStaffRepository.GetAsync(
            predicate: ls => ls.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await LibraryStaffShouldExistWhenSelected(libraryStaff);
    }
}