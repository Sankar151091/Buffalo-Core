using Buffalo.Entities.Models;
using System.Collections.Generic;

namespace Buffalo.Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
