using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Models;

namespace ConsoleSocialNetworking.Commands
{
    public class FollowCommand : Command
    {
        private readonly Deck _deck;
        private readonly string[] _commandParts;

        public FollowCommand(Deck deck, string command) : base(command)
        {
            _deck = deck;
            _commandParts = command.Split(new[] { " follows "}, StringSplitOptions.None);

        }

        public override string RegexPattern { get; } = @"\w+ follows \w+";
        public override void Execute()
        {
            _deck.AddFollows(_commandParts[0],_commandParts[1]);
        }
    }
}
