using System.Collections.Generic;
using Commando.Models;

namespace Commando.Data
{
    public class MockCommandoRepo : ICommandoRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}