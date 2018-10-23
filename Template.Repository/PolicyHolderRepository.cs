using System;
using System.Collections.Generic;
using System.Text;
using Template.Contracts.IPolicyHolder;
using Template.Entities;
using Template.Entities.Models;

namespace Template.Repository
{
    public class PolicyHolderRepository : RepositoryBase<PolicyHolder>, IPolicyHolderRepository
    {
        public PolicyHolderRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
