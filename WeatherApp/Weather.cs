using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather.Services
{
    public struct WeatherReportData
    {
        public double precipitation;
        public double temperature;
        public double uv;
    }

    public class WeatherReport
    {
        private readonly IHttpClientFactory _clientFactory;

        private async Task ClimacellApiCall()
        {
            // hardcoding lat/long until I implement location stuff


            var request = new HttpRequestMessage(HttpMethod.Get, "climacell");
            var client = _clientFactory.CreateClient("climateApi");
            var response = await client.SendAsync(request);
        }
                
        public WeatherReportData GetWeatherReport()
        {
            WeatherReportData weatherReportData;
            weatherReportData.precipitation = 0;
            weatherReportData.temperature = 16.69;
            weatherReportData.uv = 5.755;
            return weatherReportData;
        }
    }
}
