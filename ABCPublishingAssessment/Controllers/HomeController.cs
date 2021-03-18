using ABCPublishingAssessment.Models;
using ABCPublishingAssessment.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ABCPublishingAssessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string key = "preface")
        {
            var jsonData = new JsonData();
            var deserializedJson = JsonService.DeserializeJson();
            jsonData = GetDictionaryData.GetDictionaryValues(deserializedJson.JsonDict, key);
            return View(jsonData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
