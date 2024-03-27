using Application.Features.Categories.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Categories.Rules;

public class CategoryBusinessRules : BaseBusinessRules
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ILocalizationService _localizationService;

    public CategoryBusinessRules(ICategoryRepository categoryRepository, ILocalizationService localizationService)
    {
        _categoryRepository = categoryRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, CategoriesBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task CategoryShouldExistWhenSelected(Category? category)
    {
        if (category == null)
            await throwBusinessException(CategoriesBusinessMessages.CategoryNotExists);
    }



    public async Task CategoryIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        Category? category = await _categoryRepository.GetAsync(
            predicate: c => c.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await CategoryShouldExistWhenSelected(category);
    }

    public async Task CategoryNameCanNotBeDuplicatedWhenInserted(string name)
    {
        Category? result = await _categoryRepository.GetAsync(x => x.Name.ToLower() == name.ToLower());
        if (result != null)
            throw new BusinessException(CategoriesBusinessMessages.CategoryNameExists);
    }

    public async Task CategoryNameCanNotBeDuplicatedWhenUpdated(Category category)
    {
        Category? result = await _categoryRepository.GetAsync(x => x.Id != category.Id && x.Name.ToLower() == category.Name.ToLower());
        if (result != null)
            throw new BusinessException(CategoriesBusinessMessages.CategoryNameExistsUpdate);
    }
}