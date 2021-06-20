using NUnit.Framework;
using Weather.Services;

namespace WeatherAppTests
{
    public class WeatherReportTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetWeatherReport_StandardCall_ReturnExpectedData()
        {
            // creating expected data which will be faked/shimmed
            // this was literally just the weather when I made this test
            WeatherReportData expectedData;
            expectedData.precipitation = 0;
            expectedData.temperature = 16.69;
            expectedData.uv = 5.755;

            WeatherReport weatherReport = new();

            // getting the returned data from the method being tested
            var weatherData = weatherReport.GetWeatherReport();

            Assert.Equals(weatherData, expectedData);
        }
    }
}