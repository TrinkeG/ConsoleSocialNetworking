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

        public readonly Dictionary<string, Command> RegexCommands;

        public CommandRunner()
        {
            var deck = new Deck();
            var writer = new ConsoleWriter();
            RegexCommands = new Dictionary<string, Command>
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
            var command = RegexCommands.FirstOrDefault(c => MatchesCommandString(commandString,c.Key)).Value;
            command.Execute(commandString);
        }

        public bool MatchesCommandString(string commandString,string regexPattern)
        {
            return Regex.Match(commandString, regexPattern).Success;
        }
    }
}
