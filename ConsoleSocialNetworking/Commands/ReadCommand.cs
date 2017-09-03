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
    public class ReadCommand : Command
    {
        private readonly Deck _deck;
        private readonly IOutputWriter _writer;

        public ReadCommand(Deck deck, IOutputWriter writer) 
        {
            _deck = deck;
            _writer = writer;
        }
        

        public List<Post> Posts { get; set; }

        public override void Execute(string commandString)
        {
            Posts = _deck.Read(commandString);
            foreach (var post in Posts)
            {
                _writer.WriteLine(post.GetMessageString());
            }
        }

        
    }
}
