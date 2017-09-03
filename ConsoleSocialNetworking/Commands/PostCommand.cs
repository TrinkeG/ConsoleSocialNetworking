using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Models;

namespace ConsoleSocialNetworking.Commands
{
    public class PostCommand : Command
    {
        private string[] _commandParts;
        private readonly Deck _deck;
        public PostCommand(Deck deck, string commandString) : base(commandString)
        {
            _commandParts = commandString.Split(new[] {" -> "}, StringSplitOptions.None);
            _deck = deck;
        }

        public override string RegexPattern { get; } = @"\w+ -> ([\w+])*";
        public override void Execute()
        {
            _deck.AddPost(_commandParts[0],_commandParts[1]);
        }
    }
}
