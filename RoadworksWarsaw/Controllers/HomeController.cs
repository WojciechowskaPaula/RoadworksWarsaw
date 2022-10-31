using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RoadworksWarsaw.Models;
using RoadworksWarsaw.Models.Config;
using RoadworksWarsaw.Models.RoadworksDetails;
using RoadworksWarsaw.Models.RoadworksInfo;

namespace RoadworksWarsaw.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("action=index");
            try
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
            catch(Exception ex)
            {
                _logger.LogError($"action=index, msg='{ex.Message}'", ex);
                return View("Error", new ErrorViewModel());
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetRoadworksDetails(string investId)
        {
            _logger.LogInformation($"action=GetRoadworksDetails, investId={investId}");
            try
            {
                var client = new RestClient("https://api.um.warszawa.pl/api");
                var request = new RestRequest("action/get_open_invest_details");
                request.AddParameter("resource_id", "25feb40c-f26a-428b-89ba-27ffefa795a5");
                request.AddParameter("investId", $"{investId}");
                request.AddParameter("apikey", APIKey.ApiKey);
                var response = await client.GetAsync<OpenInvestsDetails>(request);
                return View(response);
            }
            catch(Exception ex)
            {
                _logger.LogError($"action=GetRoadworksDetails, msg='{ex.Message}'", ex);
                return View("Error", new ErrorViewModel());
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string street)
        {
            _logger.LogInformation($"action=search, street={street}");
            try
            {
                if (string.IsNullOrEmpty(street))
                {
                    _logger.LogWarning("action=search, msg='Street not found succesfully'");
                    return RedirectToAction("Index");
                }
                else
                {
                    var client = new RestClient("https://api.um.warszawa.pl/api");
                    var request = new RestRequest("action/get_open_invests");
                    request.AddParameter("resource_id", "26b9ade1-f5d4-439e-84b4-9af37ab7ebf1");
                    request.AddParameter("pageSize", 100);
                    request.AddParameter("startIndex", 1);
                    request.AddParameter("apikey", APIKey.ApiKey);
                    request.AddParameter("streetName", $"{street}");
                    var response = await client.GetAsync<OpenInvests>(request);
                    ViewBag.SearchString = street;
                    return View("Index", response);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"action=search, msg='{ex.Message}'", ex);
                return View("Error", new ErrorViewModel());
            }
        }
    }
}