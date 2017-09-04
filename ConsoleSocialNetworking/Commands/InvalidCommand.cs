using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Utilities;

namespace ConsoleSocialNetworking.Commands
{
    public class InvalidCommand : Command
    {
        private IOutputWriter _writer;
        public InvalidCommand(IOutputWriter writer)
        {
            _writer = writer;
        }
        public override void Execute(string commandString)
        {
            _writer.WriteLine("Error Invalid Command try again");
        }
    }
}
