using MediatR;
using Microsoft.AspNetCore.Mvc;
using BookApp.Core.Contracts.Books;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //}
        //[HttpGet]
        //public IActionResult RegisterBook()
        //{
        //    return View();
        //}

        [HttpPost]
        public async Task<IActionResult> RegisterBook([FromQuery] string Name)
        {
            AddBookCommand addBookCommand = new AddBookCommand() { Name = Name };
            var response = await _mediator.Send(addBookCommand);
            return Ok(response);
        }
        [HttpGet]
        public async Task<IActionResult> RetriveBook([FromQuery] long bookId)
        {
            var retrieveBookCommand = new RetriveCommand() { Id = bookId };
            var response = await _mediator.Send(retrieveBookCommand);

            return Ok(response);
        }
    }
}
