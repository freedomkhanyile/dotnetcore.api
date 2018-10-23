using System;
using System.Collections.Generic;
using System.Text;
using Template.Contracts.IRepositoryBase;
using Template.Entities.DTO;
using Template.Entities.Models;

namespace Template.Contracts.IClient
{
    public interface IClientRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAllClients();

        User GetClientById(Guid id);

        ClientDTO GetClientWithAccountDetails(Guid id);

        void CreateClient(User client);

        void UpdateClient(User dbClient, User client);
    }
}
