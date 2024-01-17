using System.ComponentModel.DataAnnotations;

namespace Week2CodeBasedAssesment.Models
{
    public class Company
    {
        [Required(ErrorMessage = "enter company id")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "enter Company name")]
        public string CmpName { get; set; }
        [Required(ErrorMessage = "enter city")]
        public string City { get; set; }
        [Required(ErrorMessage = "enter address")]
        public string Address { get; set; }
    }
}
