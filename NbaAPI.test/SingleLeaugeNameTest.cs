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
            Assert.AreEqual("NBA", SingleLeague.LeagueShortNameObject
                ["data"]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("111", SingleLeague.LeagueIdObject
                ["data"]["leagueId"].ToString());
        }

        [Test]
        public void ReturnInCorrectLeaugeId()
        {
            Assert.AreNotEqual("110", SingleLeague.LeagueIdObject
                ["data"]["leagueId"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName1()
        {
            Assert.AreEqual("NBA ALL STAR", SingleLeague.LeagueShortNameObject
                ["data"]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName2()
        {
            Assert.AreEqual("EuroChallenge Basketball", SingleLeague.LeagueNameObject
                ["data"]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId1()
        {
            Assert.AreEqual("1437", SingleLeague.LeagueIdObject
                ["data"]["leagueId"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId2()
        {
            Assert.AreEqual("1246", SingleLeague.LeagueIdObject
                ["data"]["leagueId"].ToString());
        }

    }
}
