using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Commands;
using ConsoleSocialNetworking.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests.CommandTests
{
    [TestClass]
    public class ReadCommandTests
    {
        [TestMethod]
        public void TestReadCommandHasPosts()
        {
            var deck = new Deck();
            deck.AddPost("Christina","I am posting a message");
            var readCommand = new ReadCommand(deck, "Christina");
            readCommand.Execute();
            Assert.AreEqual(1, readCommand.Posts.Count);
            deck.AddPost("Christina", "I am posting another message");
            readCommand.Execute();
            Assert.AreEqual(2,readCommand.Posts.Count);

        }

        [TestMethod]
        public void TestReadCommandMatchesRegex()
        {
            var deck = new Deck();
            var readCommand = new ReadCommand(deck,"Christina");
            Assert.IsTrue(readCommand.MatchesCommandString());

            readCommand = new ReadCommand(deck, "Christina bla bla");
            Assert.IsFalse(readCommand.MatchesCommandString());
        }
    }
}
