using System;
using NUnit.Framework;

namespace NbaAPI.test
{
    [TestFixture]
    public class SingleLeagueNameTest4
    {
        SingleLeague singleLeague = new SingleLeague();

        public SingleLeagueNameTest4()
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
            Assert.AreEqual("England Basketball Cup", singleLeague.LeagueNameObject["data"][77]["leagueName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeShortName()
        {
            Assert.AreEqual("EBC", singleLeague.LeagueShortNameObject["data"][77]["leagueShortName"].ToString());
        }

        [Test]
        public void ReturnCorrectLeaugeId()
        {
            Assert.AreEqual("1572", singleLeague.LeagueIdObject["data"][77]["leagueId"].ToString());
        }
    }
}
