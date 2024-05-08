using Application.Features.FeedBacks.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.FeedBacks.Commands.Create;

public class CreateFeedBackCommand : IRequest<CreatedFeedBackResponse>
{
    public required Guid MemberId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }

    public class CreateFeedBackCommandHandler : IRequestHandler<CreateFeedBackCommand, CreatedFeedBackResponse>
    {
        private readonly IMapper _mapper;
        private readonly IFeedBackRepository _feedBackRepository;
        private readonly FeedBackBusinessRules _feedBackBusinessRules;

        public CreateFeedBackCommandHandler(IMapper mapper, IFeedBackRepository feedBackRepository,
                                         FeedBackBusinessRules feedBackBusinessRules)
        {
            _mapper = mapper;
            _feedBackRepository = feedBackRepository;
            _feedBackBusinessRules = feedBackBusinessRules;
        }

        public async Task<CreatedFeedBackResponse> Handle(CreateFeedBackCommand request, CancellationToken cancellationToken)
        {
            FeedBack feedBack = _mapper.Map<FeedBack>(request);

            await _feedBackRepository.AddAsync(feedBack);

            CreatedFeedBackResponse response = _mapper.Map<CreatedFeedBackResponse>(feedBack);
            return response;
        }
    }
}