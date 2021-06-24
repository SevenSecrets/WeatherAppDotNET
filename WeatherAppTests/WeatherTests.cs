using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using WeatherApp;
using WeatherApp.WeatherReports;

namespace WeatherAppTests
{
    // These tests have to be commented out until I can actually mock
    /*[TestFixture()]
    public class TestWeatherReport
    {
        private readonly ApiKeyOptions _options;
        public TestWeatherReport(IOptions<ApiKeyOptions> options)
        {
            _options = options.Value;
        }

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetWeatherReport_StandardCall_ReturnWeatherReportData()
        {
            // creating expected data which will be faked/shimmed
            // this was literally just the weather when I made this test
            WeatherReportData expectedData;
            expectedData.precipitation = 0;
            expectedData.temperature = 16.69;
            expectedData.uv = 5.755;
            // Commented out because you can't stub or shim without VS Premium/Professional

            WeatherReport weatherReport = new();

            // getting the returned data from the method being tested
            var weatherData = weatherReport.GetWeatherReport(_options.ClimacellApiKey);

            Assert.IsInstanceOf<WeatherReportData>(weatherData);
        }
    } */
}