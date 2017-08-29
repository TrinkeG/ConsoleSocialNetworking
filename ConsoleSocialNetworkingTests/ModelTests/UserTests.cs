using System;
using System.Linq;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleSocialNetworking;

namespace ConsoleSocialNetworkingTests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void TestPostPersonal()
        {
            var christina = new User("Christina");
            christina.AddPost("This is a post");
            Assert.AreEqual(christina.Posts[0].Message, "This is a post");
        }

        [TestMethod]
        public void TestFollowUser()
        {
            var christina = new User("christina");
            christina.AddFollows(new User("Charlie"));
            Assert.AreEqual(1,christina.FollowedUsers.Count);
            Assert.AreEqual(christina.FollowedUsers[0].GetUserName(),"Charlie");
        }

        [TestMethod]
        public void TestCannotFollowDuplicate()
        {
            var christina = new User("christina");
            christina.AddFollows(new User("Charlie"));
            christina.AddFollows(new User("Charlie"));
            Assert.AreEqual(1,christina.FollowedUsers.Count(m => m.GetUserName().Equals("Charlie")));
        }

        [TestMethod]
        public void TestGetTimeLinePosts()
        {
            var christina = new User("Christina");
            christina.AddPost("This is a post");
            christina.AddPost("This also a post");
            Assert.AreEqual(2,christina.Posts.Count);
        }
    }
}
