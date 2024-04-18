using Application.Features.Users.Constants;
using Application.Features.Users.Rules;
using Application.Services.Members;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NArchitecture.Core.Application.Pipelines.Authorization;

namespace Application.Features.Users.Queries.GetById;

public class GetByIdUserQuery : IRequest<GetByIdUserResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [UsersOperationClaims.Read];

    public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQuery, GetByIdUserResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly UserBusinessRules _userBusinessRules;
        private readonly IMemberService _memberService;

        public GetByIdUserQueryHandler(IUserRepository @object, IMapper mapper, UserBusinessRules businessRules)
        {
            Object = @object;
            _mapper = mapper;
            BusinessRules = businessRules;
        }

        public GetByIdUserQueryHandler(IUserRepository userRepository, IMapper mapper, UserBusinessRules userBusinessRules, IMemberService memberService)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _userBusinessRules = userBusinessRules;
            _memberService = memberService;

        }

        public IUserRepository Object { get; }
        public UserBusinessRules BusinessRules { get; }

        public async Task<GetByIdUserResponse> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
        {
            User? user = await _userRepository.GetAsync(
                predicate: b => b.Id.Equals(request.Id),
                enableTracking: false,
                cancellationToken: cancellationToken
            );

            await _userBusinessRules.UserShouldBeExistsWhenSelected(user);

            GetByIdUserResponse response = _mapper.Map<GetByIdUserResponse>(user);

            Member? member = await _memberService.GetAsync(m => m.UserId == user!.Id);

            if (member != null)
            {
                response.MemberId = member.Id;
            }

            return response;
        }
    }
}
