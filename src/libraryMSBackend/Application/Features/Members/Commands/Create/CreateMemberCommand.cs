using Application.Features.Members.Constants;
using Application.Features.Members.Rules;
using Application.Services.OperationClaims;
using Application.Services.Repositories;
using Application.Services.UserOperationClaims;
using Application.Services.UsersService;
using AutoMapper;
using Domain.Entities;
using MailKit;
using MediatR;
using MimeKit;
using NArchitecture.Core.Application.Dtos;
using NArchitecture.Core.Application.Pipelines.Caching;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Transaction;
using NArchitecture.Core.Mailing;
using System.Security.Cryptography;

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
        private readonly NArchitecture.Core.Mailing.IMailService _mailService;
        public CreateMemberCommandHandler(IMapper mapper, IMemberRepository memberRepository,
                                         MemberBusinessRules memberBusinessRules, IUserService userService, IUserOperationClaimService userOperationClaimService, IOperationClaimService operationClaimService, NArchitecture.Core.Mailing.IMailService mailService)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
            _memberBusinessRules = memberBusinessRules;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _operationClaimService = operationClaimService;
            _mailService = mailService;
        }

        public async Task<CreatedMemberResponse> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
        {
            await _memberBusinessRules.MemberNumberCanNotBeDuplicatedWhenInserted(request.PhoneNumber);
            User user = await _userService.Register(new UserForRegisterDto() { Email = request.Email, Password = request.Password });
            string[] Roles = UserDefaultRoles.Roles;

            for (int i = 0; i < Roles.Length; i++)
            {
                OperationClaim? operationClaim = await _operationClaimService.GetAsync(oc => oc.Name == Roles[i]);
                await _userOperationClaimService.AddAsync(new UserOperationClaim() { UserId = user.Id, OperationClaimId = operationClaim!.Id });
            }
            //as
            Member member = _mapper.Map<Member>(request);
            member.UserId = user.Id;
            await _memberRepository.AddAsync(member);

            //email config
            _mailService.SendMail(new NArchitecture.Core.Mailing.Mail { Subject = "aaa",
                HtmlBody = "dsadsa", ToList = [new MailboxAddress("asdsdas", "asdsa@hotmail")] });


            CreatedMemberResponse response = _mapper.Map<CreatedMemberResponse>(member);
            return response;
        }
    }
}