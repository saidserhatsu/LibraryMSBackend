using Application.Features.BookAuthors.Constants;
using Application.Features.BookAuthors.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Pipelines.Authorization;
using MediatR;
using static Application.Features.BookAuthors.Constants.BookAuthorsOperationClaims;

namespace Application.Features.BookAuthors.Queries.GetById;

public class GetByIdBookAuthorQuery : IRequest<GetByIdBookAuthorResponse>, ISecuredRequest
{
    public Guid Id { get; set; }

    public string[] Roles => [Admin, Read];

    public class GetByIdBookAuthorQueryHandler : IRequestHandler<GetByIdBookAuthorQuery, GetByIdBookAuthorResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBookAuthorRepository _bookAuthorRepository;
        private readonly BookAuthorBusinessRules _bookAuthorBusinessRules;

        public GetByIdBookAuthorQueryHandler(IMapper mapper, IBookAuthorRepository bookAuthorRepository, BookAuthorBusinessRules bookAuthorBusinessRules)
        {
            _mapper = mapper;
            _bookAuthorRepository = bookAuthorRepository;
            _bookAuthorBusinessRules = bookAuthorBusinessRules;
        }

        public async Task<GetByIdBookAuthorResponse> Handle(GetByIdBookAuthorQuery request, CancellationToken cancellationToken)
        {
            BookAuthor? bookAuthor = await _bookAuthorRepository.GetAsync(predicate: ba => ba.Id == request.Id, cancellationToken: cancellationToken);
            await _bookAuthorBusinessRules.BookAuthorShouldExistWhenSelected(bookAuthor);

            GetByIdBookAuthorResponse response = _mapper.Map<GetByIdBookAuthorResponse>(bookAuthor);
            return response;
        }
    }
}