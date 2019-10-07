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

    public class SingleLeagueName
    {
        public RestClient Client { get; set; }
        public JObject LeagueNameObject { get; set; }
        public string LeagueNameSelected { get; set; }
        public string LeagueShortNameSelected { get; set; }
        public JObject LeagueShortNameObject { get; set; }
        public string LeagueIdSelected { get; set; }
        public JObject LeagueIdObject { get; set; }
        public SingleLeagueName() => Client = new RestClient
        {
            BaseUrl = new Uri("http://api.isportsapi.com/sport/basketball/league/basic?api_key=<flbJOqDkNsQiV1cB>")
        };

        public void GetSingleLeaugeName(string leagueName, string leagueshortname, string leagueId)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            LeagueNameSelected = leagueName;
            request.Resource = $"leagueName/{leagueName.ToLower().Replace(" ", "")}";
            LeagueShortNameSelected = leagueshortname;
            request.Resource = $"leagueShortName/{leagueshortname.ToLower().Replace(" ", "")}";
            LeagueIdSelected = leagueId;
            request.Resource = $"leagueId/{leagueId.ToLower().Replace(" ", "")}";
            IRestResponse response = Client.Execute(request);
            LeagueNameObject = JObject.Parse(response.Content);
            LeagueShortNameObject = JObject.Parse(response.Content);
            LeagueIdObject = JObject.Parse(response.Content);
        }
    }
}