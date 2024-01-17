using HandsOnEFCodeFirst_Demo2.Entities;
using HandsOnEFCodeFirst_Demo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFCodeFirst_Demo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {

        private MarksRepository marksRepository;
        public MarkController(MarksRepository marksRepository)
        {
            this.marksRepository=marksRepository;
        }
        [HttpPost, Route("AddMarks")]
        public IActionResult Add(Marks marks)
        {
            try
            {
                marks.MarksId = Guid.NewGuid();
                marksRepository.Add(marks);
                return Ok(marks);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
