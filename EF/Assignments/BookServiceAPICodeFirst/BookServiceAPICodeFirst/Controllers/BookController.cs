using BookServiceAPICodeFirst.Entities;
using BookServiceAPICodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceAPICodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookRepository bookRepository;
        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        [HttpPost,Route("AddBook")]
        public IActionResult Add(Book book)
        {
            try
            {
                bookRepository.Add(book);
                return Ok(book);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
