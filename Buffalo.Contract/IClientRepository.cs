using Buffalo.Entities.Models;
using System.Collections.Generic;

namespace Buffalo.Contracts
{
    public interface IClientRepository
    {
        IEnumerable<Client> GetAllClients(bool trackChanges);
    }
}
