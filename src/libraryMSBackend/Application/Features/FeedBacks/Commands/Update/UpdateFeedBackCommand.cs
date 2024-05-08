using Application.Features.FeedBacks.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.FeedBacks.Commands.Update;

public class UpdateFeedBackCommand : IRequest<UpdatedFeedBackResponse>
{
    public Guid Id { get; set; }
    public required Guid MemberId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }

    public class UpdateFeedBackCommandHandler : IRequestHandler<UpdateFeedBackCommand, UpdatedFeedBackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeedBackRepository _feedBackRepository;
        private readonly FeedBackBusinessRules _feedBackBusinessRules;

        public UpdateFeedBackCommandHandler(IMapper mapper, IFeedBackRepository feedBackRepository,
                                         FeedBackBusinessRules feedBackBusinessRules)
        {
            _mapper = mapper;
            _feedBackRepository = feedBackRepository;
            _feedBackBusinessRules = feedBackBusinessRules;
        }

        public async Task<UpdatedFeedBackResponse> Handle(UpdateFeedBackCommand request, CancellationToken cancellationToken)
        {
            FeedBack? feedBack = await _feedBackRepository.GetAsync(predicate: fb => fb.Id == request.Id, cancellationToken: cancellationToken);
            await _feedBackBusinessRules.FeedBackShouldExistWhenSelected(feedBack);
            feedBack = _mapper.Map(request, feedBack);

            await _feedBackRepository.UpdateAsync(feedBack!);

            UpdatedFeedBackResponse response = _mapper.Map<UpdatedFeedBackResponse>(feedBack);
            return response;
        }
    }
}