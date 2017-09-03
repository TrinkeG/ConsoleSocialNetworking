using System;
using System.Collections.Generic;
using ConsoleSocialNetworking.Models;
using ConsoleSocialNetworking.Utilities;

namespace ConsoleSocialNetworking.Commands
{
    public class WallCommand : Command
    {
        private readonly Deck _deck;
        private readonly IOutputWriter _writer;

        public WallCommand(Deck deck, IOutputWriter writer)
        {
            _deck = deck;
            _writer = writer;
        }
        
        public List<Post> Posts { get; set; }


        public override void Execute(string commandString)
        {
            var username = commandString.Split(new[] { " wall" }, StringSplitOptions.RemoveEmptyEntries)[0];
            Posts = _deck.Wall(username);
            foreach (var post in Posts)
            {
                _writer.WriteLine($"{post.UserName} - {post.GetMessageString()}");
            }
        }
    }
}
