using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests.CommandTests
{
    [TestClass]
    public class CommandRunnerTests
    {

        private const string PostRegex = @"\w+ -> ([\w+])*";
        private const string ExitRegex = @"^exit$";
        private const string FollowRegex = @"\w+ follows \w+";
        private const string ReadRegex = @"^\w+$";
        private const string WallRegex = @"\w+ wall";
        [TestMethod]
        public void TestCommandRunnerMatchesFollowCommand()
        {
            var runner = new CommandRunner();
            Assert.IsTrue(runner.MatchesCommandString( "Christina follows bob",FollowRegex));

        }

        [TestMethod]
        public void TestCommandRunnerMatchesPostCommand()
        {
            var runner = new CommandRunner();
            Assert.IsTrue(runner.MatchesCommandString( "Alice -> Posting a post", PostRegex));

        }
        [TestMethod]
        public void TestCommandRunnerMatchesExitCommand()
        {
            var runner = new CommandRunner();
            Assert.IsTrue(runner.MatchesCommandString("exit", ExitRegex));

        }

        [TestMethod]
        public void TestCommandRunnerMatchesWallCommand()
        {
            var runner = new CommandRunner();
            Assert.IsTrue(runner.MatchesCommandString("Christina wall", WallRegex));

        }

        [TestMethod]
        public void TestCommandRunnerMatchesReadCommand()
        {
            var runner = new CommandRunner();
            Assert.IsTrue(runner.MatchesCommandString("Christina", ReadRegex));

        }
    }
}
