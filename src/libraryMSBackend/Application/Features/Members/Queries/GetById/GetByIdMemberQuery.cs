using Application.Features.Members.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Pipelines.Authorization;
using static Application.Features.Members.Constants.MembersOperationClaims;

namespace Application.Features.Members.Queries.GetById;

public class GetByIdMemberQuery : IRequest<GetByIdMemberResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdMemberQueryHandler : IRequestHandler<GetByIdMemberQuery, GetByIdMemberResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _memberRepository;
        private readonly MemberBusinessRules _memberBusinessRules;

        public GetByIdMemberQueryHandler(IMapper mapper, IMemberRepository memberRepository, MemberBusinessRules memberBusinessRules)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
            _memberBusinessRules = memberBusinessRules;
        }

        public async Task<GetByIdMemberResponse> Handle(GetByIdMemberQuery request, CancellationToken cancellationToken)
        {
            Member? member = await _memberRepository.GetAsync(
                 include: b => b.Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Location)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Category)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.Publisher)
                 .Include(b => b.BookIssues).ThenInclude(b => b.Book).ThenInclude(b => b.BookAuthors).ThenInclude(b => b.Author)
                 .Include(b => b.MemberSetting),
                predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);
            await _memberBusinessRules.MemberShouldExistWhenSelected(member);

            GetByIdMemberResponse response = _mapper.Map<GetByIdMemberResponse>(member);
            return response;
        }
    }
}