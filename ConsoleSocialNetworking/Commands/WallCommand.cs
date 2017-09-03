using System;
using System.Collections.Generic;
using ConsoleSocialNetworking.Models;
using ConsoleSocialNetworking.Utilities;

namespace ConsoleSocialNetworking.Commands
{
    public class WallCommand : Command
    {
        private readonly Deck _deck;
        private IOutputWriter _testWriter;
        private readonly string _userName;

        public WallCommand(Deck deck, string commandString, IOutputWriter writer) : base(commandString)
        {
            _deck = deck;
            _userName = commandString.Split(new[] {" wall"}, StringSplitOptions.RemoveEmptyEntries)[0];
            _testWriter = writer;
        }

        public override string RegexPattern { get; } = @"\w+ wall";
        public List<Post> Posts { get; set; }


        public override void Execute()
        {
            Posts = _deck.Wall(_userName);
        }
    }
}
