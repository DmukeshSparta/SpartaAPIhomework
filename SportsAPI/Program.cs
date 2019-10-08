using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace SportsAPI
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class AppConfigReader
    {
        public static string BaseUri = ConfigurationManager.AppSettings["base_uri"];
    }

    public class SingleSports
    {
        public RestClient Client { get; set; }
        public JObject SportsObject { get; set; }
        public string SportsSelected { get; set; }

        public void GetSingleSports(string sports)
        {
            var client = new RestClient("https://free-nba.p.rapidapi.com/teams?page=0");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "free-nba.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "c463afbcbamsh8ae04b597f2ebafp13ec01jsn96c9c6b30116");
            IRestResponse response = client.Execute(request);
            SportsObject = JObject.Parse(response.Content);
        }
    }
}
