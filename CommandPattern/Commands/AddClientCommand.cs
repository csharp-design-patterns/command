using CommandPattern.Models;
using CommandPattern.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class AddClientCommand : ICommand
    {
        private readonly IClientRepository _clientRepository;
        private readonly Client _client;

        public AddClientCommand(IClientRepository clientRepository, Client client) =>
            (_clientRepository, _client) = (clientRepository, client);

        public bool CanExecute()
        {
            if (_client == null)
                return false;

            return _clientRepository.GetClient(_client.Id) == null;
        }

        public void Execute()
        {
            if (_client == null)
                return;

            _clientRepository.Add(_client);
        }

        public void Undo()
        {
            if (_client == null)
                return;

            _clientRepository.Remove(_client.Id);
        }
    }
}
