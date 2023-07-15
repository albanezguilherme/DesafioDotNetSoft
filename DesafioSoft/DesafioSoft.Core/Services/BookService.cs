using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;
using DesafioSoft.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoft.Core.Services
{
    public class BookService : GenericService<Book>, IBookService
    {
        public BookService(IBookRepository genericRepository) : base(genericRepository)
        {
        }
    }
}
