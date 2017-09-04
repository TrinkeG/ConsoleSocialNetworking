using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ConsoleSocialNetworking.Commands;
using ConsoleSocialNetworking.Models;
using ConsoleSocialNetworking.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests.CommandTests
{
    [TestClass]
    public class FollowCommandTests
    {
        [TestMethod]
        public void TestFollowCommandAddsFollowers()
        {
            var deck = new Deck();
            var followCommand = new FollowCommand(deck);
            followCommand.Execute("Christina follows Bob");
            Assert.IsTrue(deck.GetCreateUser("Christina").FollowedUsers.Exists(m => m.GetUserName().Equals("Bob")));
        }
    }
}