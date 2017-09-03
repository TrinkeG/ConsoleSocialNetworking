using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Commands;
using ConsoleSocialNetworking.Models;
using ConsoleSocialNetworking.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests.CommandTests
{
    [TestClass]
    public class WallCommandTests
    {

        [TestMethod]
        public void TestWallCommandMatchesRegex()
        {
            var testWriter = new TestWriter();
            var deck = new Deck();
            var wallCommand = new WallCommand(deck, "Alice wall", testWriter);
            Assert.IsTrue(wallCommand.MatchesCommandString());

            wallCommand = new WallCommand(deck, "Christina follows Alice", testWriter);
            Assert.IsFalse(wallCommand.MatchesCommandString());
        }

        [TestMethod]
        public void TestWallCommandDeckHasPosts()
        {
            var testWriter = new TestWriter();
            var deck = new Deck();
            var postCommand = new PostCommand(deck, "Alice -> One Post");
            postCommand.Execute();
            postCommand = new PostCommand(deck, "Alice -> Two Post");
            postCommand.Execute();
            var followCommand = new FollowCommand(deck,"Bob follows Alice");
            followCommand.Execute();
            var wallCommand = new WallCommand(deck, "Bob wall",testWriter);
            wallCommand.Execute();
            Assert.AreEqual(2, wallCommand.Posts.Count);
        }
        
    }
}
