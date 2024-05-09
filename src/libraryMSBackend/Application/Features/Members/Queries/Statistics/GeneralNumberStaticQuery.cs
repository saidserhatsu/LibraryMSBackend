using System.Threading;
using System.Threading.Tasks;
using Application.Services.Repositories;
using MediatR;

namespace Application.Features.Members.Queries.Statistics
{
    public class GeneralNumberStaticQuery : IRequest<object>
    {
    }

    public class GeneralNumberStaticQueryHandler : IRequestHandler<GeneralNumberStaticQuery, object>
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMagazineRepository _magazineRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly ILibraryStaffRepository _libraryStaffRepository;
        private readonly ICatalogRepository _catalogRepository;

        public GeneralNumberStaticQueryHandler(IBookRepository bookRepository, IMagazineRepository magazineRepository,
            IMemberRepository memberRepository, ILibraryStaffRepository libraryStaffRepository, ICatalogRepository catalogRepository)
        {
            _bookRepository = bookRepository;
            _magazineRepository = magazineRepository;
            _memberRepository = memberRepository;
            _libraryStaffRepository = libraryStaffRepository;
            _catalogRepository = catalogRepository;
        }

        public async Task<object> Handle(GeneralNumberStaticQuery request, CancellationToken cancellationToken)
        {
            var generalNumber = new
            {
                NumberOfBooks = await _bookRepository.CountAsync(),
                NumberOfMagazines = await _magazineRepository.CountAsync(),
                NumberOfMembers = await _memberRepository.CountAsync(),
                NumberOfLibraryStaff = await _libraryStaffRepository.CountAsync(),
                NumberOfCatalogs = await _catalogRepository.CountAsync()
            };

            return generalNumber;
        }
    }
}