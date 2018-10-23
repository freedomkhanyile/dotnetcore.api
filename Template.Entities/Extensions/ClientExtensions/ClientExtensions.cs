using System;
using System.Collections.Generic;
using System.Text;
using Template.Entities.Models;

namespace Template.Entities.Extensions.ClientExtensions
{
    public static class ClientExtensions
    {
        public static void Map(this User dbClient, User client)
        {
            dbClient.FirstName = client.FirstName;           
            dbClient.Surname = client.Surname;
            dbClient.Email = client.Email;
            dbClient.StatusId = client.StatusId;
        }
    }
}
