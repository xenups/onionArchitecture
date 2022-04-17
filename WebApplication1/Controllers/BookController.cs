using Book.Core.ApplicationServices.Book;
using Book.Core.Contracts.Book;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private readonly IAddBookService _addBookService;
        public BookController(IAddBookService addBookService)
        {
            _addBookService = addBookService;
        }
        [HttpGet]
        public IActionResult AddBookController([FromQuery] string bookName)
        {
            AddBookInput bookInput = new AddBookInput() { Name = bookName };
            AddBookOutput bookOutput = _addBookService.Execute(bookInput);
            return base.Ok(bookOutput);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
