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
    public class ReadCommandTests
    {
        [TestMethod]
        public void TestReadCommandHasPosts()
        {
            var testWriter = new TestWriter();
            var deck = new Deck();
            deck.AddPost("Christina","I am posting a message");
            var readCommand = new ReadCommand(deck,testWriter);
            readCommand.Execute("Christina");
            Assert.AreEqual(1, readCommand.Posts.Count);
            deck.AddPost("Christina", "I am posting another message");
            readCommand.Execute("Christina");
            Assert.AreEqual(2,readCommand.Posts.Count);
        }

        [TestMethod]
        public void TestReadCommandConsoleOutput()
        {
            var testWriter = new TestWriter();
            var deck = new Deck();
            deck.AddPost("Christina", "I am posting a message");
            var readCommand = new ReadCommand(deck, testWriter);
            readCommand.Execute("Christina");
            Assert.AreEqual(1, testWriter.WrittenLines.Count);
            Assert.AreEqual("I am posting a message (just now)", testWriter.WrittenLines[0]);
            deck.AddPost("Christina", "I am posting another message");
            readCommand.Execute("Christina");
            Assert.AreEqual("I am posting another message (just now)", testWriter.WrittenLines[2]);
            Assert.AreEqual(3, testWriter.WrittenLines.Count);

        }
        
    }
}
