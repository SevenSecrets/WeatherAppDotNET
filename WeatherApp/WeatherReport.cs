using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp.WeatherReports
{
    public struct WeatherReportData
    {
        public long precipitation;
        public double temperature;
    }

    public class WeatherReport
    {
        public async Task<Dictionary<string, string>> GetWeatherReport(string climacellApiKey)
        {
            string latitude = "42.8237618";
            string longitude = "-71.2216286";

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://api.climacell.co/v3/weather/realtime?lat={latitude}&lon={longitude}&fields=temp%2Cprecipitation"),
                Headers =
                {
                    { "apikey", climacellApiKey },
                }
            };

            var response = await client.SendAsync(request);
            
            if(!response.IsSuccessStatusCode)
            {
                string err = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException(err);
            }

            string jsonBody = await response.Content.ReadAsStringAsync();
            ClimacellResponse climacellResponse = JsonConvert.DeserializeObject<ClimacellResponse>(jsonBody);

            Dictionary<string, string> weatherReportData = new();

            weatherReportData.Add("latitude", climacellResponse.lat.ToString());
            weatherReportData.Add("longitude", climacellResponse.lon.ToString());
            weatherReportData.Add("precipitation", climacellResponse.precipitation["value"].ToString());
            weatherReportData.Add("temp", climacellResponse.temp["value"].ToString());

            return weatherReportData;
        }
    }
}
