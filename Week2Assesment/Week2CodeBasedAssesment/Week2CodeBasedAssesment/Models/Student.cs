using System.ComponentModel.DataAnnotations;

namespace Week2CodeBasedAssesment.Models
{
    public class Student
    {
        [Required(ErrorMessage = "enter student id")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "enter student name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "enter qualification")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "enter skill")]
        public string Skill { get; set; }
    }
}
