using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleSocialNetworking;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests
{
    [TestClass]
    public class PostsTests
    {
        [TestMethod]
        public void GetFormattedPostText()
        {
            //Time has a public accessor to enable this testing. This may be a bad idea? 
            //ToDo: post doesnt care how it is formatted >.<  Also wallformat is different!!
            var post = new Post("This is a test post","christina ");
            Assert.AreEqual(post.GetMessageString(), "This is a test post (just now)");
            post.DatePosted= post.DatePosted.AddMinutes(-1);
            Assert.AreEqual(post.GetMessageString(), "This is a test post (1 minute ago)");
            post.DatePosted = post.DatePosted.AddMinutes(-2);
            Assert.AreEqual(post.GetMessageString(), "This is a test post (3 minutes ago)");
        }
    }
}
