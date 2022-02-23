using Buffalo.Contracts;
using Buffalo.Entities;
using Buffalo.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Buffalo.Repository
{
    public class ClientRepository : RepositoryBase<ExternalClientContext, Client>, IClientRepository
    {
        public ClientRepository(ExternalClientContext clientContext)
            :base(clientContext)
        {
        }

        public IEnumerable<Client> GetAllClients(bool trackChanges) => 
            FindAll(trackChanges)
            .ToList();
    }
}
