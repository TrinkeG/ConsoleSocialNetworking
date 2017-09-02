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
    public class TimeFormatterTests
    {
        [TestMethod]
        public void TestSeconds()
        {
            TimeFormatter formatter = new TimeFormatter();
            string timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddSeconds(-5));
            Assert.AreEqual("5 seconds ago",timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddSeconds(-55));
            Assert.AreEqual("55 seconds ago", timeStamp);
        }

        [TestMethod]
        public void TestJustNow()
        {
            var formatter = new TimeFormatter();
            string timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime());
            Assert.AreEqual("just now", timeStamp);
        }

        [TestMethod]
        public void TestMinutes()
        {
            var formatter = new TimeFormatter();
            var timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddMinutes(-5));
            Assert.AreEqual("5 minutes ago", timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddMinutes(-55));
            Assert.AreEqual("55 minutes ago",timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddMinutes(-1));
            Assert.AreEqual("1 minute ago", timeStamp);
        }

        [TestMethod]
        public void TestHours()
        {
            var formatter = new TimeFormatter();
            var timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddHours(-5));
            Assert.AreEqual("5 hours ago", timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddHours(-5).AddMinutes(-30));
            Assert.AreEqual("5 hours 30 minutes ago", timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddHours(-1));
            Assert.AreEqual("1 hour ago", timeStamp);
        }

        [TestMethod]
        public void TestDays()
        {
            var formatter = new TimeFormatter();
            var timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddDays(-5));
            Assert.AreEqual("5 days ago", timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddDays(-2).AddHours(-5).AddMinutes(-30));
            Assert.AreEqual("2 days ago", timeStamp);
            timeStamp = formatter.FormatTimeStamp(DateTime.Now.ToUniversalTime().AddDays(-1));
            Assert.AreEqual("1 day ago", timeStamp);
        }
    }
}
