using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Models;

namespace ConsoleSocialNetworking.Commands
{
    public class ReadCommand : Command
    {
        private readonly Deck _deck;
        private readonly string _commandString;

        private const string RgxPattern = @"^\w+$";


        public ReadCommand(Deck deck, string commandString) : base(commandString)
        {
            _deck = deck;
            _commandString = commandString;
        }

        public List<Post> Posts { get; set; }

        public void Execute()
        {
            Posts = _deck.Read(_commandString);
        }


        public  override string RegexPattern { get; } = RgxPattern;
    }
}
