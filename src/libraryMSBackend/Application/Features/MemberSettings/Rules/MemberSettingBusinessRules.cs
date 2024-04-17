using Application.Features.MemberSettings.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.MemberSettings.Rules;

public class MemberSettingBusinessRules : BaseBusinessRules
{
    private readonly IMemberSettingRepository _memberSettingRepository;
    private readonly ILocalizationService _localizationService;

    public MemberSettingBusinessRules(IMemberSettingRepository memberSettingRepository, ILocalizationService localizationService)
    {
        _memberSettingRepository = memberSettingRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, MemberSettingsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task MemberSettingShouldExistWhenSelected(MemberSetting? memberSetting)
    {
        if (memberSetting == null)
            await throwBusinessException(MemberSettingsBusinessMessages.MemberSettingNotExists);
    }

    public async Task MemberSettingIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        MemberSetting? memberSetting = await _memberSettingRepository.GetAsync(
            predicate: ms => ms.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await MemberSettingShouldExistWhenSelected(memberSetting);
    }
}