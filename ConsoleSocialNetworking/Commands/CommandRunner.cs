using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Models;
using ConsoleSocialNetworking.Utilities;

namespace ConsoleSocialNetworking.Commands
{
    public class CommandRunner
    {
        private const string PostRegex =  @"\w+ -> ([\w+])*";
        private const string ExitRegex = @"^exit$";
        private const string FollowRegex = @"\w+ follows \w+";
        private const string ReadRegex = @"^\w+$";
        private const string WallRegex = @"\w+ wall";

        private readonly Dictionary<string, Command> _regexCommands;

        public CommandRunner()
        {
            var deck = new Deck();
            var writer = new ConsoleWriter();
            _regexCommands = new Dictionary<string, Command>
            {
                {@"\w+ -> ([\w+])*", new PostCommand(deck)},
                {@"^exit$", new ExitCommand()},
                {@"\w+ follows \w+", new FollowCommand(deck)},
                {@"^\w+$", new ReadCommand(deck, writer)},
                {@"\w+ wall", new WallCommand(deck, writer)}
            };
        }
        public void ExecuteCommand(string commandString)
        {
            var command = _regexCommands.FirstOrDefault(c => MatchesCommandString(commandString,c.Key)).Value;
            command.Execute(commandString);
        }

        public bool MatchesCommandString(string commandString,string regexPattern)
        {
            return Regex.Match(commandString, regexPattern).Success;
        }
    }
}
