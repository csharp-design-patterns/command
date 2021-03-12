using CommandPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Repositories
{
    public interface IClientRepository
    {
        void Add(Client client);

        Client GetClient(int id);

        void Remove(int id);
    }
}
