using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace NbaAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SingleLeague
    {
        public RestClient Client { get; set; }
        public string LeagueDetailsSelected { get; set; }
        public JObject LeagueNameObject { get; set; }

        /*      public string LeagueNameSelected { get; set; }
                public string LeagueShortNameSelected { get; set; }
                public string LeagueIdSelected { get; set; }
        */
        public JObject LeagueShortNameObject { get; set; }

        public JObject LeagueIdObject { get; set; }
        public SingleLeague() => Client = new RestClient
        {
            BaseUrl = new Uri("http://api.isportsapi.com/sport/basketball/league/basic?api_key=flbJOqDkNsQiV1cB")
        };

        public void GetSingleLeauge(string leagueDetails)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            LeagueDetailsSelected = leagueDetails ;

            IRestResponse response = Client.Execute(request);

            LeagueNameObject = JObject.Parse(response.Content);
            LeagueShortNameObject = JObject.Parse(response.Content);
            LeagueIdObject = JObject.Parse(response.Content);
        }
    }
}