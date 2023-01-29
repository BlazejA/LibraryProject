using Library.Models;
using Library.Repository.Context;
using Library.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("rent")]
    [ApiController]
    public class RentBookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly IRentBookRepository _rentBookRepository;

        public RentBookController(IBookRepository bookRepository, IRentBookRepository rentBookRepository)
        {
            _bookRepository = bookRepository;
            _rentBookRepository = rentBookRepository;
        }

        [HttpPost]
        public ActionResult RentBook([FromBody] int bookId, [FromBody] int userId)
        {
            if (_rentBookRepository.RentBook(bookId, userId))
                return Ok();
            else
                return BadRequest();
        }
        
        [HttpPost]
        public ActionResult ReturnBook([FromBody]int bookId, [FromBody] int userId)
        {
            if (_rentBookRepository.ReturnBook(bookId, userId))
                return Ok();
            else
                return BadRequest();
        }
    }
}
