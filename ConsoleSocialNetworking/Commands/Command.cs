using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Commands
{
    public abstract class Command
    {
        //public string RegexPattern;
        //public abstract string RegexPattern { get;  }
        //private readonly string _commandString;
        

        /**/

        public abstract void Execute(string commandString);
    }
}
