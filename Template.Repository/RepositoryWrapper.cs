using System;
using System.Collections.Generic;
using System.Text;
using Template.Contracts;
using Template.Contracts.IClient;
using Template.Contracts.IPolicyHolder;
using Template.Entities;

namespace Template.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        private IClientRepository _client;
        private IPolicyHolderRepository _policyHolder;
        public IClientRepository Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new ClientRepository(_repoContext);
                }

                return _client;
            }
        }

        public IPolicyHolderRepository PolicyHolder
        {
            get
            {
                if (_policyHolder == null)
                {
                    _policyHolder = new PolicyHolderRepository(_repoContext);
                }

                return _policyHolder;
            }
        }
    }
}
