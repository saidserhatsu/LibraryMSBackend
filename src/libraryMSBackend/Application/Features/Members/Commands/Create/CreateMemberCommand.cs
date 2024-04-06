using Application.Features.Members.Rules;
using Application.Services.OperationClaims;
using Application.Services.Repositories;
using Application.Services.UserOperationClaims;
using Application.Services.UsersService;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Dtos;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;

namespace Application.Features.Members.Commands.Create;

public class CreateMemberCommand : IRequest<CreatedMemberResponse>, ICacheRemoverRequest, ILoggableRequest, ITransactionalRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool Subscribe { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public bool BypassCache { get; }
    public string? CacheKey { get; }
    public string[]? CacheGroupKey => ["GetMembers"];

    public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand, CreatedMemberResponse>
    {
        private readonly IMapper _mapper;
        private readonly IMemberRepository _memberRepository;
        private readonly MemberBusinessRules _memberBusinessRules;
        private readonly IUserService _userService;
        private readonly IUserOperationClaimService _userOperationClaimService;
        private readonly IOperationClaimService _operationClaimService;
        public CreateMemberCommandHandler(IMapper mapper, IMemberRepository memberRepository,
                                         MemberBusinessRules memberBusinessRules, IUserService userService, IUserOperationClaimService userOperationClaimService, IOperationClaimService operationClaimService)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
            _memberBusinessRules = memberBusinessRules;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _operationClaimService = operationClaimService;
        }

        public async Task<CreatedMemberResponse> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            await _memberBusinessRules.MemberNumberCanNotBeDuplicatedWhenInserted(request.PhoneNumber);
            User user = await _userService.Register(new UserForRegisterDto() { Email = request.Email, Password = request.Password });

            OperationClaim? operationClaim = await _operationClaimService.GetAsync(oc => oc.Name == "BookIssuesOperationClaims.Create"); //Ornek yetki

            // TODO: Kullaniciyla ilgili temel yetkilerin oldugu bir array olusturulacak. sonra da bu yetkiler Handle icinte otomatik verilecek

            await _userOperationClaimService.AddAsync(new UserOperationClaim() { UserId = user.Id, OperationClaimId = operationClaim!.Id });

            Member member = _mapper.Map<Member>(request);
            member.UserId = user.Id;


            CreatedMemberResponse response = _mapper.Map<CreatedMemberResponse>(member);
            return response;
        }
    }
}