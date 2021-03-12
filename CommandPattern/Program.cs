using CommandPattern.Commands;
using CommandPattern.Models;
using CommandPattern.Repositories;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IClientRepository clientRepository = default;
            Client client = default;

            var addClientCommand = new AddClientCommand(clientRepository, client);

            var manager = new CommandManager();
            manager.Invoke(addClientCommand);

            // ... do something

            manager.Undo();
        }
    }
}
