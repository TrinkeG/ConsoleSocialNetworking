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
        private readonly Deck _deck;
        public PostCommand(Deck deck)
        {
            _deck = deck;
        }
        
        public override void Execute(string commandString)
        {
            string[] commandParts = commandString.Split(new[] { " -> " }, StringSplitOptions.None);
            _deck.AddPost(commandParts[0],commandParts[1]);
        }
    }
}
