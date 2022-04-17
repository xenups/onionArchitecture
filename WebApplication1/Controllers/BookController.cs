using Book.Core.ApplicationServices.Book;
using Book.Core.Contracts.Book;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AddBookControllerAsync([FromQuery] string bookName)
        {
            var response = await _mediator.Send(new AddCommand() { Name = bookName });
            return base.Ok(response);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
