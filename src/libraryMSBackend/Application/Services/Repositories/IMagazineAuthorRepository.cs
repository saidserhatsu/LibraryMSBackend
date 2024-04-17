using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IMagazineAuthorRepository : IAsyncRepository<MagazineAuthor, Guid>, IRepository<MagazineAuthor, Guid>
{
}