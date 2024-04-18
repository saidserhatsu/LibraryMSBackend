using Application.Features.Members.Constants;
using Application.Features.Members.Rules;
using Application.Services.MemberSettings;
using Application.Services.OperationClaims;
using Application.Services.Repositories;
using Application.Services.UserOperationClaims;
using Application.Services.UsersService;
using AutoMapper;
using Domain.Entities;
using MediatR;
using MimeKit;
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
        private readonly NArchitecture.Core.Mailing.IMailService _mailService;
        private readonly IMemberSettingService _memberSettingService;
        public CreateMemberCommandHandler(IMapper mapper, IMemberRepository memberRepository,
                                         MemberBusinessRules memberBusinessRules, IUserService userService, IUserOperationClaimService userOperationClaimService, IOperationClaimService operationClaimService, NArchitecture.Core.Mailing.IMailService mailService, IMemberSettingService memberSettingService)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
            _memberBusinessRules = memberBusinessRules;
            _userService = userService;
            _userOperationClaimService = userOperationClaimService;
            _operationClaimService = operationClaimService;
            _mailService = mailService;
            _memberSettingService = memberSettingService;
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

            Member member = _mapper.Map<Member>(request);
            member.UserId = user.Id;

           var savedMember= await _memberRepository.AddAsync(member);

            MemberSetting memberSetting = await _memberSettingService.AddAsync(new MemberSetting() { MemberId=savedMember.Id });
            member.MemberSetting.Id = memberSetting.Id;


            //_mailService.SendMail(new NArchitecture.Core.Mailing.Mail
            //{
            //    Subject = "Test Mail",
            //    HtmlBody = "Welcome to the Tobeto Public Library",
            //    ToList = [new MailboxAddress($"{member.FirstName} {member.LastName}", $"{member.Email}")]
            //});


            CreatedMemberResponse response = _mapper.Map<CreatedMemberResponse>(member);
            return response;
        }
    }
}