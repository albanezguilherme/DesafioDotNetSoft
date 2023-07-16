using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return _bookService.GetAll();
        }

        [HttpGet("/{id}")]
        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpPost]
        public ActionResult CreateBook(Book book)
        {
            return Ok(_bookService.Add(book));
        }

        [HttpPatch]
        public ActionResult UpdateBook(Book book)
        {
            return Ok(_bookService.Update(book));
        }

        [HttpDelete]
        public ActionResult DeleteBook(Book book)
        {
            return Ok(_bookService.Delete(book));
        }
    }
}
