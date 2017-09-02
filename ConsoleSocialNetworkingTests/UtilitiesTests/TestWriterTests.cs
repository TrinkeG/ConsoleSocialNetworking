using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleSocialNetworkingTests.UtilitiesTests
{
    [TestClass]
    public class TestWriterTests
    {
        [TestMethod]
        public void TestConsoleStorage()
        {
            TestWriter testOutputWriter = new TestWriter();
            testOutputWriter.WriteLine("First Console line");
            testOutputWriter.WriteLine("Second Console line");
            Assert.AreEqual("First Console line", testOutputWriter.WrittenLines[0]);
            Assert.AreEqual("Second Console line", testOutputWriter.WrittenLines[1]);

        }
    }
}

