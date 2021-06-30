using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using WeatherApp;
using WeatherApp.WeatherReports;

namespace WeatherAppTests
{
    // These tests have to be commented out until I can actually mock/shim http requests
    /*
    [TestFixture()]
    public class TestWeatherReport
    {
        private readonly ApiKeyOptions _options;
        public TestWeatherReport(IOptions<ApiKeyOptions> options)
        {
            _options = options.Value;
        }

        [Test]
        public void GetWeatherReport_StandardCall_ReturnWeatherReportData()
        {
            WeatherReport weatherReport = new();

            // getting the returned data from the method being tested
            var weatherData = weatherReport.GetWeatherReport(_options.ClimacellApiKey);

            Assert.IsInstanceOf<WeatherReportData>(weatherData);
        }
    }
    */
}