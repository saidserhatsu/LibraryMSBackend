using Application.Features.Publishers.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Application.Features.Publishers.Rules;

public class PublisherBusinessRules : BaseBusinessRules
{
    private readonly IPublisherRepository _publisherRepository;
    private readonly ILocalizationService _localizationService;

    public PublisherBusinessRules(IPublisherRepository publisherRepository, ILocalizationService localizationService)
    {
        _publisherRepository = publisherRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, PublishersBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task PublisherShouldExistWhenSelected(Publisher? publisher)
    {
        if (publisher == null)
            await throwBusinessException(PublishersBusinessMessages.PublisherNotExists);
    }

    public async Task PublisherIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Publisher? publisher = await _publisherRepository.GetAsync(
            predicate: p => p.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await PublisherShouldExistWhenSelected(publisher);
    }

    public async Task PublisherNameCanNotBeDuplicatedWhenInserted(string name)
    {
        Publisher? result = await _publisherRepository.GetAsync(x => x.Name.ToLower() == name.ToLower());
        if (result != null)
            throw new BusinessException(PublishersBusinessMessages.PublisherNameExists);
    }

    public async Task PublisherNameCanNotBeDuplicatedWhenUpdated(Publisher publisher)
    {
        Publisher? result = await _publisherRepository.GetAsync(x => x.Id != publisher.Id && x.Name.ToLower() == publisher.Name.ToLower());
        if (result != null)
            throw new BusinessException(PublishersBusinessMessages.PublisherNameExists);
    }
}