using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherApp.WeatherReports;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly ApiKeyOptions _apiKeyOptions;

        public WeatherController(ILogger<WeatherController> logger, IOptions<ApiKeyOptions> apiKeyOptions)
        {
            _logger = logger;
            _apiKeyOptions = apiKeyOptions.Value;
        }

        // GET /
        [HttpGet]
        public async Task<Dictionary<string, string>> GetIndex()
        {
            WeatherReport weatherReport = new();
            Dictionary<string, string> weatherReportData = await weatherReport.GetWeatherReport(_apiKeyOptions.ClimacellApiKey);
            return weatherReportData;
        }
    }
}
