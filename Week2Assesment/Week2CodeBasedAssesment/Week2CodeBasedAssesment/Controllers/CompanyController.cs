using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2CodeBasedAssesment.Models;
using Week2CodeBasedAssesment.Repository;

namespace Week2CodeBasedAssesment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyRepository companyRepository;
        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository= companyRepository;
        }
        [HttpPost, Route("AddStudent")]
        public IActionResult Add(Company company)
        {
            try
            {

                companyRepository.AddCompany(company);
                return StatusCode(200, company);
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetAllCompanies")]
        public IActionResult GetAllCompanies()
        {
            try
            {

                List<Company> companies = companyRepository.GetAllCompanies();
                return StatusCode(200, companies);

            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetCompanyById/{CompanyId}")]

        public IActionResult GetCompanyById(int CompanyId)
        {
            try
            {
                return StatusCode(200, companyRepository.GetCompanyById(CompanyId));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpGet, Route("GetCompanyByCity/{City}")]

        public IActionResult GetCompanyByCity(string City)
        {
            try
            {
                return StatusCode(200, companyRepository.GetCompanyByCity(City));
            }
            catch (Exception ex)
            {
                return StatusCode(501, ex);
            }
        }
        [HttpDelete("DeleteCompany/{CompanyId}")]
        public IActionResult Delete(int CompanyId)
        {
            try
            {
                companyRepository.DeleteCompany(CompanyId);
                return StatusCode(200, "Student was deleted");
            }
            catch (Exception ex)
            {

                return StatusCode(501, ex);
            }
        }
    }
}
