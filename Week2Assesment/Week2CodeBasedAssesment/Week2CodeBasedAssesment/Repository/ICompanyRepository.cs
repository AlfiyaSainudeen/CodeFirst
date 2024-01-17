using Week2CodeBasedAssesment.Models;

namespace Week2CodeBasedAssesment.Repository
{
    public interface ICompanyRepository
    {
        void AddCompany(Company company);

        List<Company> GetAllCompanies();
        List<Company> GetCompanyById(int CompanyId);
        List<Company> GetCompanyByCity(string City);
        void DeleteCompany(int CompanyId);
    }
}
