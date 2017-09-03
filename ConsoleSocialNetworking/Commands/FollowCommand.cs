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

        public FollowCommand(Deck deck)
        {
            _deck = deck;

        }
        
        public override void Execute(string stringCommand)
        {
            string[] commandParts = stringCommand.Split(new[] { " follows " }, StringSplitOptions.None);
            _deck.AddFollows(commandParts[0],commandParts[1]);
        }
    }
}
