using System;
using NUnit.Framework;

namespace NbaAPI.test
{
    [TestFixture]
    public class SingleLeagueNameTest2
    {
        SingleLeague singleLeague = new SingleLeague();

        public SingleLeagueNameTest2()
        {
            singleLeague.GetSingleLeauge("NBA ALL STAR");
        }

        [Test]
        public void Message()
        {
            Assert.AreEqual("success", singleLeague.LeagueNameObject["message"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeName()
        {
            Assert.AreEqual("NBA ALL STAR", singleLeague.LeagueNameObject["data"][3]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeShortName()
        {
            Assert.AreEqual("NBA All Star", singleLeague.LeagueShortNameObject["data"][3]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("1437", singleLeague.LeagueIdObject["data"][3]["leagueId"].ToString());
        }
    }
}
