//using demoApp;
//using System.Linq;
//using demoApp.Controllers;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using Microsoft.Extensions.Logging;

//namespace demoTest
//{
//    [TestClass]
//    public class TestWeatherForecastController
//    {
//        WeatherForecastController weatherForecastController;
//        IEnumerable<WeatherForecast> weatherForecastResponse;

//        [TestInitialize]
//        public void Setup()
//        {
//            weatherForecastController = new WeatherForecastController(null);
//            weatherForecastResponse = weatherForecastController.Get();
//        }

//        [TestMethod] public void WeatherForecastControllerIsNotNull() => Assert.IsNotNull(weatherForecastController);
//        [TestMethod] public void GetWeatherForecastIsNotNull() => Assert.IsNotNull(weatherForecastResponse);
//        [TestMethod] public void GetWeatherForecastHasContent() => Assert.AreNotEqual(0, weatherForecastResponse.ToList().Count);
//        [TestMethod] public void GetWeatherForecastHas5Rows() => Assert.AreEqual(5, weatherForecastResponse.ToList().Count);
//    }
//}
