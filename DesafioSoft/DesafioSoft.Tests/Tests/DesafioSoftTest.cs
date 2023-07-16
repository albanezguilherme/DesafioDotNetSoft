using System.Linq.Expressions;
using DesafioSoft.Controllers;
using DesafioSoft.Core.Entities;
using DesafioSoft.Core.Interfaces.Repositories;
using DesafioSoft.Core.Interfaces.Services;
using DesafioSoft.Core.Services;
using DesafioSoft.Infrastructure;
using DesafioSoft.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace DesafioSoft.Tests.Api.Tests;

[TestFixture]
public class DesafioSoftTest
{
    private BookController bookController;
    private IBookService bookService;
    private Mock<IBookRepository> bookRepositoryMock;
    private Mock<DesafioSoftContext> desafioSoftContextMock;

    [SetUp]
    public void Init()
    {
        desafioSoftContextMock = new Mock<DesafioSoftContext>();
        bookRepositoryMock = new Mock<IBookRepository>();
        bookService = new BookService(bookRepositoryMock.Object);
        bookController = new BookController(bookService);
    }

    [Test]
    public void GetAllBooksTest()
    {
        bookRepositoryMock.Setup(m => m.GetAll()).Returns(new List<Book>());

        var result = bookController.GetBooks();
        Assert.IsInstanceOf(typeof(IEnumerable<Book>), result);
        Assert.IsNotNull(result);
    }

    [Test]
    public void GetBookByIdTest()
    {
        bookRepositoryMock.Setup(m => m.GetById(1)).Returns(new Book());

        var result = bookController.GetBookById(1);
        Assert.IsInstanceOf(typeof(Book), result);
        Assert.IsNotNull(result);
    }

    [Test]
    public void AddBookSuccessTest()
    {
        bookRepositoryMock.Setup(m => m.Add(new Book())).Returns("Book added successfully");
        var book = new Book("Book Title", "John", "2000"); 

        var result = bookController.CreateBook(book);
        Assert.IsNotNull(result);
        Assert.DoesNotThrow(() =>bookController.CreateBook(new Book()));
    }

    [Test]
    public void UpdateBookSuccessTest()
    {
        var book = new Book("Book Title", "John", "2000");
        bookRepositoryMock.Setup(m => m.Update(new Book())).CallBase();

        var result = bookController.UpdateBook(book);
        Assert.IsNotNull(result);
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void DeleteBookSuccessTest()
    {
        bookRepositoryMock.Setup(m => m.Delete(new Book())).Returns("Book removed successfully");

        var result = bookController.DeleteBook(new Book());
        Assert.IsNotNull(result);
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void AddBookWithEmptyTitleTest()
    {
        var book = new Book("", "John", "2000");

        var result = bookService.Add(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Title cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void AddBookWithEmptyYearTest()
    {
        var book = new Book("Book Title", "John", "");

        var result = bookService.Add(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Year cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void AddBookWithEmptyAuthorTest()
    {
        var book = new Book("Book Title", "", "2000");

        var result = bookService.Add(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Author cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void UpdateBookWithEmptyAuthorTest()
    {
        var book = new Book("Book Title", "", "2000");

        var result = bookService.Update(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Author cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void UpdateBookWithEmptyTitleTest()
    {
        var book = new Book("", "John", "2000");

        var result = bookService.Update(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Title cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }

    [Test]
    public void UpdateBookWithEmptyYearTest()
    {
        var book = new Book("Book Title", "John", "");

        var result = bookService.Update(book);
        Assert.IsNotNull(result);
        Assert.That(result, Is.EqualTo("Year cannot be empty"));
        Assert.DoesNotThrow(() => bookController.CreateBook(new Book()));
    }
}