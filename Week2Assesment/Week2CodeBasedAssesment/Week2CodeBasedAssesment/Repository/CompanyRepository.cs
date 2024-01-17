using Week2CodeBasedAssesment.Models;

namespace Week2CodeBasedAssesment.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        List<Company> companies = new List<Company>();
        public void AddCompany(Company company)
        {
            try
            {
                companies.Add(company);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteCompany(int CompanyId)
        {

            try
            {
                foreach (var company in companies)
                {
                    if (company.CompanyId == CompanyId)
                    {
                        companies.Remove(company);
                        break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Company> GetAllCompanies()
        {

            try
            {
                return companies;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Company> GetCompanyByCity(string City)
        {
            List<Company> cmp = new List<Company>();
            try
            {
                foreach (var company in companies)
                {
                    if (company.City == City)
                    {
                        cmp.Add(company);
                    }
                }
                return cmp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Company> GetCompanyById(int CompanyId)
        {
            List<Company> cmp = new List<Company>();
            try
            {
                foreach (var company in companies)
                {
                    if (company.CompanyId == CompanyId)
                    {
                        cmp.Add(company);
                    }
                }
                return cmp;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
