using System;
using NUnit.Framework;

namespace NbaAPI.test
{
    [TestFixture]
    public class SingleLeagueNameTest
    {
        SingleLeague singleLeague = new SingleLeague();

        public SingleLeagueNameTest()
        {
            singleLeague.GetSingleLeauge("National Basketball Association", "NBA", "111");
        }

        [Test]
        public void Message()
        {
            Assert.AreEqual("success", singleLeague.LeagueNameObject["message"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName()
        {
            Assert.AreEqual("National Basketball Association", singleLeague.LeagueNameObject["data"][0]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeShortName()
        {
            Assert.AreEqual("NBA", singleLeague.LeagueShortNameObject["data"][0]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("111", singleLeague.LeagueIdObject["data"][0]["leagueId"].ToString());
        }

        [Test]
        public void ReturnInCorrectLeaugeId()
        {
            Assert.AreNotEqual("110", singleLeague.LeagueIdObject["data"][0]["leagueId"].ToString());
        }
    }
}
