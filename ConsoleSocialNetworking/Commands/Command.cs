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
        public abstract string RegexPattern { get;  }
        private readonly string _commandString;

        public Command(string commandString)
        {
            _commandString = commandString;
        }

        public bool MatchesCommandString()
        {
            return Regex.Match(_commandString, RegexPattern).Success;
        }

        public abstract void Execute();
    }
}
