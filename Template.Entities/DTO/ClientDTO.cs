using System;
using System.Collections.Generic;
using System.Text;
using Template.Entities.Models;

namespace Template.Entities.DTO
{
    public class ClientDTO : IEntity
    {      
        public Guid Id { get; set; }         
        public string FirstName { get; set; }    
        public string Surname { get; set; }      
        public string Email { get; set; }

        public int StatusId { get; set; }

        public IEnumerable<Account> Accounts { get; set; }
        public ClientDTO() { }

        public ClientDTO(User client)
        {
            Id = client.Id;
            FirstName = client.FirstName;
            Surname = client.Surname;
            Email = client.Email;
            StatusId = client.StatusId;
        }
    }
}
