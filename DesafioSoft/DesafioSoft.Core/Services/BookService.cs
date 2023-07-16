using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;
using DesafioSoft.Core.Interfaces.Services;

namespace DesafioSoft.Core.Services
{
    public class BookService : GenericService<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository genericRepository) : base(genericRepository)
        {
            _bookRepository = genericRepository;
        }

        public string Add(Book entity)
        {
            var isValid = BookValidation(entity);
            return isValid == "" ? _bookRepository.Add(entity) : isValid;
        }

        public string Update(Book entity)
        {
            var isValid = BookValidation(entity);
            return isValid == "" ? _bookRepository.Update(entity) : isValid;
        }

        private static string BookValidation(Book entity)
        {
            if (entity.Year == "") return "Year cannot be empty";
            if (entity.Author == "") return "Author cannot be empty";
            if (entity.Title == "") return "Title cannot be empty";

            return "";
        }
    }
}
