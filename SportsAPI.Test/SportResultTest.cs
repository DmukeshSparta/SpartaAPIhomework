using System;
using NUnit.Framework;

namespace SportsAPI.Test
{
    [TestFixture]
    public class SportResultTest
    {
        SingleSports sports = new SingleSports();

        public SportResultTest()
        {
            sports.GetSingleSports("");
        }

        [Test]
        public void TestMessage()
        {
            Assert.AreEqual("30", sports.SportsObject["meta"]["per_page"].ToString());
        }

        [Test]
        public void TestTeamCity()
        {
            Assert.AreEqual("Atlanta", sports.SportsObject["data"][0]["city"].ToString());
        }

        [Test]
        public void TestTeamConference()
        {
            Assert.AreEqual("East", sports.SportsObject["data"][16]["conference"].ToString());
        }

        [Test]
        public void TestHeaderServer()
        {
          
        }

        [Test]
        public void TestHeaderDate()
        {

        }

        [Test]
        public void TestHeaderContent_Length()
        {

        }

    }
}
