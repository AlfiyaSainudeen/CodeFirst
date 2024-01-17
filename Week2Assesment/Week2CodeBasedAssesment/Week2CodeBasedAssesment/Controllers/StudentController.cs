using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2CodeBasedAssesment.Models;
using Week2CodeBasedAssesment.Repository;

namespace Week2CodeBasedAssesment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }



        [HttpPost, Route("AddStudent")]
        public IActionResult Add(Student student)
        {
            try
            {

                studentRepository.AddStudent(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {

                List<Student> students = studentRepository.GetAllStudents();
                return StatusCode(200, students);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetStudentByQualification/{Qualification}")]

        public IActionResult GetStudentByQualification(string Qualification)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentByQualification(Qualification));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetStudentBySkill/{Skill}")]

        public IActionResult GetStudentBySkill(string Skill)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentBySkill(Skill));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpGet, Route("GetStudentById/{StudentId}")]

        public IActionResult GetStudentById(int StudentId)
        {
            try
            {
                return StatusCode(200, studentRepository.GetStudentById(StudentId));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }

        [HttpPut("UpdateStudent")]
        public IActionResult Update(Student student)
        {
            try
            {
                studentRepository.Update(student);
                return StatusCode(200, student);
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
        [HttpDelete("DeleteStudent/{StudentId}")]
        public IActionResult Delete(int StudentId)
        {
            try
            {
                studentRepository.Delete(StudentId);
                return StatusCode(200, "Student was deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}

