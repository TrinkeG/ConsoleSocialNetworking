using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking;
using ConsoleSocialNetworking.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests
{
    [TestClass]
    public class DeckTests
    {
        //
        [TestMethod]
        public void TestUserCanFollow()
        {
            var deck = new Deck();
            deck.AddFollows("Christina", "Bob");
            Assert.AreEqual(deck.GetCreateUser("Christina").FollowedUsers[0].GetUserName(),"Bob");
        }

        [TestMethod]
        public void TestWallReturnsPosts()
        {
            var deck = new Deck();
            deck.AddFollows("Christina", "Bob");
            var bob = deck.GetCreateUser("Bob");
            bob.AddPost("This is bob post one");
            bob.AddPost("This is bob post two");
            deck.AddFollows("Christina", "Dylan");
            var dylan = deck.GetCreateUser("Dylan");
            dylan.AddPost("This is Dylan post one");
            dylan.AddPost("This is Dylan post two");
            Assert.AreEqual(4,deck.Wall("Christina").Count);
        }

        [TestMethod]
        public void TestWallContainsUsersOwnPosts()
        {
            var deck = new Deck();
            deck.AddFollows("Christina", "Bob");
            var bob = deck.GetCreateUser("Bob");
            bob.AddPost("This is bob post one");
            bob.AddPost("This is bob post two");
            deck.AddFollows("Christina", "Dylan");
            var dylan = deck.GetCreateUser("Dylan");
            dylan.AddPost("This is Dylan post one");
            var christina = deck.GetCreateUser("Christina");
            christina.AddPost("This is my own post");
            Assert.IsTrue(deck.Wall("Christina").Exists(p=>p.Message== "This is my own post"));
        }

        [TestMethod]
        public void TestReadReturnsPosts()
        {
            var deck = new Deck();
            var bob = deck.GetCreateUser("Bob");
            bob.AddPost("This is bob post one");
            bob.AddPost("This is bob post two");
            Assert.AreEqual(2,deck.Read("Bob").Count);
        }

        [TestMethod]
        public void TestUserCanPost()
        {
            var deck = new Deck();
            deck.AddPost("Christina", "This is a post");
            Assert.AreEqual(deck.Read("Christina").Count,1);
        }

    }
}
