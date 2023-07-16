using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;

namespace DesafioSoft.Infrastructure.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(DesafioSoftContext context) : base(context)
        {
        }
    }
}
