using Buffalo.Contracts;
using Buffalo.Entities;
using Buffalo.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Buffalo.Repository
{
    public class CompanyRepository : RepositoryBase<RepositoryContext, Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
            FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
    }
}
