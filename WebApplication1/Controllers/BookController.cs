using BookApp.Core.Contracts.Books;
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
        public async Task<IActionResult> RegisterBook()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> RegisterBook([FromQuery] AddBookCommand addBookCommand)
        {
            var response = await _mediator.Send(addBookCommand);
            return Ok(response);
        }
        
    }
}
