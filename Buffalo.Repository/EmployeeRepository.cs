using Buffalo.Contracts;
using Buffalo.Entities;
using Buffalo.Entities.Models;

namespace Buffalo.Repository
{
    public class EmployeeRepository : RepositoryBase<RepositoryContext, Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
