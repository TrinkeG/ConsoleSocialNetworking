using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Models;

namespace ConsoleSocialNetworking.Commands
{
    public class CommandRunner
    {
        private readonly Deck _deck;
        private const string PostRegex =  @"\w+ -> ([\w+])*";
        private const string ExitRegex = @"^exit$";
        private const string FollowRegex = @"\w+ follows \w+";
        private const string ReadRegex = @"^\w+$";
        private const string WallRegex = @"\w+ wall";

        private Dictionary<string, Command> regexCommands;

        public CommandRunner()
        {
            _deck = new Deck();
            regexCommands= new Dictionary<string, Command>();
            regexCommands.Add(@"\w+ -> ([\w+])*",new PostCommand(_deck));
        }
        public void ExecuteCommand(string commandString)
        {
            Command commandToExecute;
        }

        public bool MatchesCommandString(string commandString,string regexPattern)
        {
            return Regex.Match(commandString, regexPattern).Success;
        }
    }
}
