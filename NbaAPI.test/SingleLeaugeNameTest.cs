using System;
using NUnit.Framework;

namespace NbaAPI.test
{
    [TestFixture]
    public class SingleLeagueNameTest
    {
        SingleLeagueName SingleLeague = new SingleLeagueName();

        public SingleLeagueNameTest()
        {
            SingleLeague.GetSingleLeaugeName("National Basketball Association", "NBA", "111");
        }

        [Test]
        public void Message()
        {
            Assert.AreEqual("success", SingleLeague.LeagueNameObject["message"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName()
        {
            Assert.AreEqual("National Basketball Association", SingleLeague.LeagueNameObject
                ["data"]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeShortName()
        {
            Assert.AreEqual("NBA", SingleLeague.LeagueNameObject
                ["data"]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("111", SingleLeague.LeagueNameObject
                ["data"]["leagueId"].ToString());
        }
    }
}
