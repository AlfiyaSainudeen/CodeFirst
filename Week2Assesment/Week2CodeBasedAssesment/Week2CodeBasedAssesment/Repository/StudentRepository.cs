using Week2CodeBasedAssesment.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Week2CodeBasedAssesment.Repository
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> students = new List<Student>();
        public void AddStudent(Student student)
        {
            try
            {
                students.Add(student);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); 
            }
        }

        public void Delete(int StudentId)
        {
         
                try
                {
                    foreach (var student in students)
                    {
                        if (student.StudentId == StudentId)
                        {
                            students.Remove(student);
                        break;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            
        }

        public List<Student> GetAllStudents()
        {
            try
            {
                return students;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetStudentByQualification(string Qualification)
        {
            List<Student> stud = new List<Student>();
            try
            {
                foreach (var student in students)
                {
                    if (student.Qualification == Qualification)
                    {
                        stud.Add(student);
                    }
                }
                return stud;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetStudentBySkill(string Skill)
        {
            List<Student> stud = new List<Student>();
            try
            {
                foreach (var student in students)
                {
                    if (student.Skill == Skill)
                    {
                        stud.Add(student);
                    }
                }
                return stud;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Student> GetStudentById(int StudentId)
        {
            List<Student> stud = new List<Student>();

            try
            {
              foreach(var student in students)
                {
                    if(student.StudentId==StudentId)
                    {
                        stud.Add(student);
                    }
                }
                return stud;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Student student)
        {
            try
            {
                foreach (var stud in students)
                {
                    if (stud.StudentId == student.StudentId)
                    {
                        stud.Skill = student.Skill;
                        stud.Qualification = student.Qualification;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
