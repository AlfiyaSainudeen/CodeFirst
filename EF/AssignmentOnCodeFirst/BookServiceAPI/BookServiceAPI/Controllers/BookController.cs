using BookServiceAPI.Entities;
using BookServiceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        IRepository<Book> bookRepository;
        public BookController(IRepository<Book> repository)
        {
            this.bookRepository = repository;
        }
        [HttpPost, Route("AddBook")]
        public IActionResult AddBook([FromBody] Book book)
        {
            try
            {
                bookRepository.Add(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet, Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {
                var books = bookRepository.GetAll();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetBooksByAuthor/{author}")]
        public IActionResult GetBooksByAuthor(string author)
        {
            try
            {
                var books = bookRepository.GetBooksByAuthor(author);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet, Route("GetBooksByLang/{lang}")]
        public IActionResult GetBooksByLang(string lang)
        {
            try
            {
                var books = bookRepository.GetBooksByLang(lang);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet, Route("GetBooksByYear/{year}")]
        public IActionResult GetBooksByYear(int year)
        {
            try
            {
                var books = bookRepository.GetBooksByYear(year);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut, Route("EditBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookRepository.Update(book);
                return StatusCode(200, "Updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete, Route("Deletebook/{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookRepository.Delete(id);
                return StatusCode(200, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
