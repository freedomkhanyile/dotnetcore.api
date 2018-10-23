using Microsoft.EntityFrameworkCore;
using Template.Entities.Models;

namespace Template.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
               :base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PolicyHolder> PolicyHolders { get; set; }

    }
}
