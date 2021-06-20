using System;
using System.Collections.Generic;
using System.Linq;
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
        public WeatherReportData GetWeatherReport()
        {
            throw new NotImplementedException("Please create a test first.");
        }
    }
}
