using System;
using NUnit.Framework;

namespace NbaAPI.test
{
    [TestFixture]
    public class SingleLeagueNameTest3
    {
        SingleLeague singleLeague = new SingleLeague();

        public SingleLeagueNameTest3()
        {
            singleLeague.GetSingleLeauge("");
        }

        [Test]
        public void Message()
        {
            Assert.AreEqual("success", singleLeague.LeagueNameObject["message"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName()
        {
            Assert.AreEqual("Super Basketball League", singleLeague.LeagueNameObject["data"][11]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeShortName()
        {
            Assert.AreEqual("SBL", singleLeague.LeagueShortNameObject["data"][11]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("10415", singleLeague.LeagueIdObject["data"][11]["leagueId"].ToString());
        }
    }
}
