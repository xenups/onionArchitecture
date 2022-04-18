using MediatR;
using Microsoft.AspNetCore.Mvc;
using BookApp.Core.Contracts.Books;

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
        public IActionResult RegisterBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterBook([FromForm] AddBookCommand addBookCommand)
        {
            var response = await _mediator.Send(addBookCommand);
            return Ok(response);
        }

    }
}
