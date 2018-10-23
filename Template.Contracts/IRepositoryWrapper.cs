using System;
using System.Collections.Generic;
using System.Text;
using Template.Contracts.IClient;
using Template.Contracts.IPolicyHolder;

namespace Template.Contracts
{
    public interface IRepositoryWrapper
    {
        IClientRepository Client { get; }
        IPolicyHolderRepository PolicyHolder { get; }
    }
}
