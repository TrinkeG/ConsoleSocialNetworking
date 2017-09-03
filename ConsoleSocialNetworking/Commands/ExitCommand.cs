using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Commands
{
    public class ExitCommand :Command
    {
        
        public override void Execute(string commandString)
        {
            Environment.Exit(0);
        }
    }
}
