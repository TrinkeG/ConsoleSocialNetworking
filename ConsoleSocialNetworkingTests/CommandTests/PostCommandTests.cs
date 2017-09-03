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
    public class PostCommandTests
    {

        /*[TestMethod]
        public void TestPostCommandMatchesRegex()
        {
            var deck = new Deck();
            var postCommand = new PostCommand(deck, "Alice -> I Love the weather today");
            Assert.IsTrue(postCommand.MatchesCommandString());

            postCommand = new PostCommand(deck, "Christina follows Alice");
            Assert.IsFalse(postCommand.MatchesCommandString());
        }*/

        [TestMethod]
        public void TestPostCommandAddsNewPosts()
        {
            var deck = new Deck();
            var postCommand = new PostCommand(deck);
            postCommand.Execute("Alice -> I Love the weather today");
            Assert.IsTrue(deck.GetCreateUser("Alice").Posts.Exists(m => m.Message.Equals("I Love the weather today")));
        }
    }
}
