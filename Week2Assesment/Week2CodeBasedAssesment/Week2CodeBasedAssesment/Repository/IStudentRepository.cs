using Week2CodeBasedAssesment.Models;

namespace Week2CodeBasedAssesment.Repository
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        void Update(Student student);
      
        void Delete(int StudentId);
        List<Student> GetAllStudents();
        List<Student> GetStudentById(int StudentId);
        List<Student> GetStudentByQualification(string Qualification);
        List<Student> GetStudentBySkill(string Skill);
    }
}
