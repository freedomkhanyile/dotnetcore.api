using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Contracts.IClient;
using Template.Entities;
using Template.Entities.DTO;
using Template.Entities.Extensions.ClientExtensions;
using Template.Entities.Models;

namespace Template.Repository
{
    public class ClientRepository : RepositoryBase<User>, IClientRepository
    {
        public ClientRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }


        public IEnumerable<User> GetAllClients()
        {
            return FindAll().Where(c=> c.StatusId == 1);
        }

        public User GetClientById(Guid id)
        {
            return FindByCondition(client => client.Id.Equals(id))
            .DefaultIfEmpty(new User())
            .FirstOrDefault();
        }

        public ClientDTO GetClientWithAccountDetails(Guid id)
        {
            return new ClientDTO(GetClientById(id))
            {
                Accounts = RepositoryContext.Accounts
                .Where(a => a.UserId == id)
            };
        }

        public void CreateClient(User client)
        {
            client.Id = Guid.NewGuid();
            Create(client);
            Save();
        }

        public void UpdateClient(User dbClient, User client)
        {
            dbClient.Map(client);
            Update(dbClient);
            Save();
        }
    }
}
