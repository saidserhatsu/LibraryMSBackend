using Application.Features.BookIssues.Constants;
using Application.Features.BookIssues.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.BookIssues.Constants.BookIssuesOperationClaims;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.BookIssues.Queries.GetById;

public class GetByIdBookIssueQuery : IRequest<GetByIdBookIssueResponse>
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdBookIssueQueryHandler : IRequestHandler<GetByIdBookIssueQuery, GetByIdBookIssueResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookIssueRepository _bookIssueRepository;
        private readonly BookIssueBusinessRules _bookIssueBusinessRules;

        public GetByIdBookIssueQueryHandler(IMapper mapper, IBookIssueRepository bookIssueRepository, BookIssueBusinessRules bookIssueBusinessRules)
        {
            _mapper = mapper;
            _bookIssueRepository = bookIssueRepository;
            _bookIssueBusinessRules = bookIssueBusinessRules;
        }

        public async Task<GetByIdBookIssueResponse> Handle(GetByIdBookIssueQuery request, CancellationToken cancellationToken)
        {
            BookIssue? bookIssue = await _bookIssueRepository.GetAsync(predicate: bi => bi.Id == request.Id, cancellationToken: cancellationToken,
                include: bi => bi.Include(bi => bi.FineDues).Include(bi => bi.Book).Include(bi => bi.Member).Include(bi => bi.LibraryStaff)
                );
            await _bookIssueBusinessRules.BookIssueShouldExistWhenSelected(bookIssue);

            GetByIdBookIssueResponse response = _mapper.Map<GetByIdBookIssueResponse>(bookIssue);
            return response;
        }
    }
}