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
        readonly IOutputWriter _writer = new ConsoleWriter();
        public CommandRunner()
        {
            var deck = new Deck();
            RegexCommands = new Dictionary<string, Command>
            {
                {@"\w+ -> ([\w+])*", new PostCommand(deck)},
                {@"^exit$", new ExitCommand()},
                {@"\w+ follows \w+", new FollowCommand(deck)},
                {@"^\w+$", new ReadCommand(deck, _writer)},
                {@"\w+ wall", new WallCommand(deck, _writer)}
            };
        }
        public void ExecuteCommand(string commandString)
        {
            //If it doesn't match regex in dictionary it is an invalid command
            var command = RegexCommands.FirstOrDefault(c => MatchesCommandString(commandString,c.Key)).Value ??
                          new InvalidCommand(_writer);
            command.Execute(commandString);
        }

        public bool MatchesCommandString(string commandString,string regexPattern)
        {
            return Regex.Match(commandString, regexPattern).Success;
        }
    }
}
