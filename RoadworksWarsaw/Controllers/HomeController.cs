using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RoadworksWarsaw.Models;
using RoadworksWarsaw.Models.Config;
using RoadworksWarsaw.Models.RoadworksDetails;
using RoadworksWarsaw.Models.RoadworksInfo;
using System.Diagnostics;

namespace RoadworksWarsaw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var client = new RestClient("https://api.um.warszawa.pl/api");
            var request = new RestRequest("action/get_open_invests");
            request.AddParameter("resource_id", "26b9ade1-f5d4-439e-84b4-9af37ab7ebf1");
            request.AddParameter("pageSize", 100);
            request.AddParameter("startIndex", 1);
            request.AddParameter("apikey", APIKey.ApiKey);
            var response = await client.GetAsync<OpenInvests>(request);
            return View(response);
        }


        public async Task <IActionResult> GetRoadworksDetails(string investId)
        {
            var client = new RestClient("https://api.um.warszawa.pl/api");
            var request = new RestRequest("action/get_open_invest_details");
            request.AddParameter("resource_id", "25feb40c-f26a-428b-89ba-27ffefa795a5");
            request.AddParameter("investId", $"{investId}");
            request.AddParameter("apikey", APIKey.ApiKey);
            var response = await client.GetAsync<OpenInvestsDetails>(request);
            return View(response);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}